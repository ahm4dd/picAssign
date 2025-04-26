using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;

namespace pictureAhmed
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\range\\source\\repos\\pictureAhmed\\Database1.mdf;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        VideoCaptureDevice videoCapture;
        FilterInfoCollection filterInfo;
        bool cameraOn = false;

        void StartCamera()
        {
            try
            {
                filterInfo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                videoCapture = new VideoCaptureDevice(filterInfo[0].MonikerString);
                videoCapture.NewFrame += new NewFrameEventHandler(Camera_On);
                videoCapture.Start();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Camera_On(object sender, NewFrameEventArgs eventArgs)
        {
            studentPictureBox2.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "Insert into tblS (Picture) VALUES (@picture)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@picture", getPhoto());
                    int success = cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                studentPictureBox.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private byte[] getPhoto()
        {
            MemoryStream memoryStream = new MemoryStream();
            if (studentPictureBox.Image != null)
            {
                try
                {
                    // Create a new Bitmap from the existing image
                    // This helps in ensuring a valid format for saving
                    using (Bitmap tempBitmap = new Bitmap(studentPictureBox.Image))
                    {
                        // Save the new bitmap as JPEG (or Png)
                        tempBitmap.Save(memoryStream, ImageFormat.Jpeg);
                        // Or save as Png if preferred:
                        // tempBitmap.Save(memoryStream, ImageFormat.Png);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error converting and saving image: " + ex.Message);
                    return null;
                }
            }
            else
            {
                return null;
            }
            return memoryStream.ToArray();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCamera();
        }

        void StopCamera()
        {
            try
            {
                if (videoCapture != null && videoCapture.IsRunning)
                {
                    videoCapture.SignalToStop();
                    videoCapture.WaitForStop();
                    videoCapture.NewFrame -= Camera_On; // Unsubscribe from the event
                    videoCapture = null;
                    cameraOn = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error stopping camera: " + ex.Message);
            }
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (cameraOn == false)
            {
                StartCamera();
                if (videoCapture != null && videoCapture.IsRunning) // Only set cameraOn to true if camera started successfully
                {
                    cameraOn = true;
                    btnStartStop.Text = "Stop";
                }
            }
            else
            {
                StopCamera();
                btnStartStop.Text = "Start";
                studentPictureBox2.Image = null;
            }
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            if (studentPictureBox2.Image != null)
            {
                // Create a new Bitmap from the studentPictureBox2 image
                // This ensures we have a separate copy
                Bitmap capturedImage = new Bitmap(studentPictureBox2.Image);

                studentPictureBox.Image = capturedImage;

                // StopCamera();
                // btnStartStop.Text = "Start";
            }
            else
            {
                MessageBox.Show("Please start the camera and wait for a frame before capturing.");
            }
        }
    }
}
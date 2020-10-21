using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Camera1
{
    public partial class Form1 : Form
    {
        private bool haveDevice = false;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource = null;

        public Form1()
        {
            InitializeComponent();
        }
        private void GetFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap img = (Bitmap)eventArgs.Frame.Clone();
            pb_frame.Image = img;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_save.Enabled = false;
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                cb_devices.Items.Clear();
                if (videoDevices.Count == 0)
                    throw new ApplicationException();

                haveDevice = true;
                foreach (FilterInfo device in videoDevices)
                {
                    cb_devices.Items.Add(device.Name);
                }
                cb_devices.SelectedIndex = 0;
            }
            catch (ApplicationException)
            {
                haveDevice = false;
                cb_devices.Items.Add("No devices found!");
            }
        }

        private void btn_capture_Click(object sender, EventArgs e)
        {
            if (haveDevice)
            {
                if(btn_capture.Text == "Start")
                {
                    videoSource = new VideoCaptureDevice(videoDevices[cb_devices.SelectedIndex].MonikerString);
                    videoSource.NewFrame += new NewFrameEventHandler(GetFrame);
                    videoSource.Start();
                    btn_capture.Text = "Stop";
                    btn_save.Enabled = false;
                }
                else
                {
                    videoSource.SignalToStop();
                    videoSource = null;
                    btn_capture.Text = "Start";
                    btn_save.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("No devices found!");
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (videoSource != null)
            {
                videoSource.SignalToStop();
                videoSource = null;
            }
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {   
            saveFileDialog1.Filter = "JPEG (*.jpg;*.jpeg;*jpeg;*.jfif)|*.jpg;*.jpeg;*jpeg;*.jfif";
            saveFileDialog1.FileName = "New frame";
            DialogResult res = saveFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                pb_frame.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }
    }
}

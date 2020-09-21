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
        private bool DeviceExist = false;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource = null;

        public Form1()
        {
            InitializeComponent();
        }
        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap img = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = img;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_salvar.Enabled = false;
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                cb_dispositivos.Items.Clear();
                if (videoDevices.Count == 0)
                    throw new ApplicationException();

                DeviceExist = true;
                foreach (FilterInfo device in videoDevices)
                {
                    cb_dispositivos.Items.Add(device.Name);
                }
                cb_dispositivos.SelectedIndex = 0; //make dafault to first cam
            }
            catch (ApplicationException)
            {
                DeviceExist = false;
                cb_dispositivos.Items.Add("Nenhum dispositivo encontrado!");
            }
        }

        private void btn_capturar_Click(object sender, EventArgs e)
        {
            if (DeviceExist)
            {
                if(btn_capturar.Text == "Iniciar")
                {
                    videoSource = new VideoCaptureDevice(videoDevices[cb_dispositivos.SelectedIndex].MonikerString);
                    videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
                    videoSource.Start();
                    btn_capturar.Text = "Parar";
                    btn_salvar.Enabled = false;
                }
                else
                {
                    videoSource.SignalToStop();
                    videoSource = null;
                    //pictureBox1.Image = null;
                    btn_capturar.Text = "Iniciar";
                    btn_salvar.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Nenhum dispositivo encontrado!");
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            if (videoSource != null)
            {
                videoSource.SignalToStop();
                videoSource = null;
            }
            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {   
            saveFileDialog1.Filter = "JPEG (*.jpg;*.jpeg;*jpeg;*.jfif)|*.jpg;*.jpeg;*jpeg;*.jfif";
            DialogResult res = saveFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }
    }
}

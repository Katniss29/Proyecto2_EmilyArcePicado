using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace PROYECTO2_EmilyArcePicado
{
    public partial class RegistroDeMarcas : Form
    {
        //path where photos are saved
        public string destino = @"C:\Users\arcee\source\repos\Proyecto2_EmilyArcePicado\PROYECTO2_EmilyArcePicado\imag\IMAGENES";
        //attributes to make validations and for the help in the search of the camera(s) that the device has
        private bool hayDispositivos;
        private FilterInfoCollection misDispositivos;
        private VideoCaptureDevice miWebCam;

      
        
        //method that is responsible for closing the window and going to the exit login that can only be exited if it is an authorized user
        private void RegistroDeMarcas_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            LOGINSALIDA oLoginSalida = new LOGINSALIDA();
            oLoginSalida.Show();
            cerrarWebCam();
        }

        //method that helps to upload the photo that is used as background in the interface
        public RegistroDeMarcas()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo1.jpg");
            this.BackgroundImage = img;
        }
        private void RegistroDeMarcas_Load(object sender, EventArgs e)
        {
            cargarDispositivos();
        }

        //method used to close the camera of the device
        private void cerrarWebCam()
        {
            if (miWebCam != null && miWebCam.IsRunning)
            {
                miWebCam.SignalToStop();
                miWebCam = null;
            }
        }

        //This button only takes the photo, it does not mark anything about the employees.
        private void marcarRegistro_Click(object sender, EventArgs e)
        {
            if (miWebCam !=null && miWebCam.IsRunning)
            {
                pictureBox2.Image = pictureBox1.Image;
                
                pictureBox2.Image.Save(destino + nombreImagen() + ".Jpeg" , ImageFormat.Jpeg);
            }
        }


        //method that is responsible for selecting the camera that will take the photo
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            cerrarWebCam();
            int i = webCam.SelectedIndex;
            string nombreVideo = misDispositivos[i].MonikerString;
            miWebCam = new VideoCaptureDevice(nombreVideo);
            miWebCam.NewFrame += new NewFrameEventHandler(capturar);
            miWebCam.Start();
        }

        //method that is responsible for loading all the cameras that the device has in the comboBox
        public void cargarDispositivos()
        {
            misDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (misDispositivos.Count > 0)
            {
                hayDispositivos = true;
                for (int i = 0; i < misDispositivos.Count; i++)
                {
                    webCam.Items.Add(misDispositivos[i].Name.ToString());
                    webCam.Text = misDispositivos[0].ToString();
                }
            }
            else
            {
                hayDispositivos = false;
            }
        }

        //method that captures the image
        private void capturar(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = Imagen;
        }

        //method that generates random names to put on the photos since if photos with the same name are not taken they are overwritten
        public string nombreImagen()
        {
            string valores = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var arreglo = new char[8];
            var random = new Random();

            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = valores[random.Next(valores.Length)];
            }

            var resultString = new String(arreglo);
            
            return resultString;
        }
    }
}

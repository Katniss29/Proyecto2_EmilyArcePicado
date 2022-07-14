﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO2_EmilyArcePicado
{
    public partial class Administrativa : Form
    {
        public Administrativa()
        {
            InitializeComponent();
            Bitmap imge = new Bitmap(Application.StartupPath + @"\img\fondo1.jpg");
            this.BackgroundImage = imge;
        }

        //screen output method
        private void Administrativa_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            VentanaPrincipal oVentanaPrincipal = new VentanaPrincipal();
            oVentanaPrincipal.Show();
        }


        //Method that closes the window and opens the CRUD window
        private void btnMantenimiento_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Mantenimiento oManteminiento = new Mantenimiento();
            oManteminiento.Show();

        }



      

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Seguridad oSeguridad = new Seguridad();
            oSeguridad.Show();
        }
    }
}

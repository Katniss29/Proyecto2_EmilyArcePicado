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
    public partial class Mantenimiento : Form
    {
        public Mantenimiento()
        {
            InitializeComponent();
        }

        private void MANTENIMIENTO_Load(object sender, EventArgs e)
        {

        }

        private void btnMantenimientoEmpleados_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrudEmpleados oCrudEmpleados = new CrudEmpleados();
            oCrudEmpleados.Show();
        }
    }
}

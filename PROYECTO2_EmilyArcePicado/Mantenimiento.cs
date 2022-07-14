using System;
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
        //The image used in the background is loaded
        public Mantenimiento()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo1.jpg");
            this.BackgroundImage = img;

        }

        //Button that is responsible for closing the window and opening the crud employees
        private void btnMantenimientoEmpleados_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrudEmpleados oCrudEmpleados = new CrudEmpleados();
            oCrudEmpleados.Show();
        }

        //method to exit and return to the administrative screen
        private void Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Administrativa oAdministrativa = new Administrativa();
            oAdministrativa.Show();
        }

        private void btnDepartamentos_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrudDepartamentos oCrudDepartamentos = new CrudDepartamentos();
            oCrudDepartamentos.Show();
        }

        private void btnDiasFeriados_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrudDiasFeriados oCrudDiasFeriados = new CrudDiasFeriados();
            oCrudDiasFeriados.Show();
        }

        private void btnHorarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrudHorarios oCrudHorarios = new CrudHorarios();
            oCrudHorarios.Show();
        }
    }
}

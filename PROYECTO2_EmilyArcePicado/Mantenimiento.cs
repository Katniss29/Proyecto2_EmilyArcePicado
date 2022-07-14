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
        public Mantenimiento()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\fondo1.jpg");
            this.BackgroundImage = img;

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

        private void Mantenimiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Administrativa oAdministrativa = new Administrativa();
            oAdministrativa.Show();
        }
    }
}

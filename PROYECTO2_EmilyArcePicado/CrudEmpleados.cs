using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocio;

namespace PROYECTO2_EmilyArcePicado
{
    public partial class CrudEmpleados : Form
    {
        public CrudEmpleados()
        {
            InitializeComponent();
        }
        public void cargarGridDatosEstudiantes(DataTable informacionEstudiantes)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < informacionEstudiantes.Rows.Count; i++)
            {
                int indice = dataGridView1.Rows.Add();
                dataGridView1.Rows[indice].Cells[0].Value = informacionEstudiantes.Rows[i]["ID_EMPLEADOS"];
                dataGridView1.Rows[indice].Cells[1].Value = informacionEstudiantes.Rows[i]["NOMBRE"];
                dataGridView1.Rows[indice].Cells[2].Value = informacionEstudiantes.Rows[i]["APELLIDO1"];
                dataGridView1.Rows[indice].Cells[3].Value = informacionEstudiantes.Rows[i]["APELlIDO2"];
                dataGridView1.Rows[indice].Cells[4].Value = informacionEstudiantes.Rows[i]["DIRECCION"];
                dataGridView1.Rows[indice].Cells[5].Value = informacionEstudiantes.Rows[i]["TELEFONO"];
                dataGridView1.Rows[indice].Cells[6].Value = informacionEstudiantes.Rows[i]["SALARIO_HORAS"];
            }
        }
        public void refrescar()
        {
            String[] datos = { "id_empleados", "nombre", "apellido1", "apellido2", "direccion", "telefono", "salario_horas" };
            DataTable informacionEstudiante = NEGOCIO.consultarTodosElementos("empleados", datos);
            cargarGridDatosEstudiantes(informacionEstudiante);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            refrescar();
        }
    }
}

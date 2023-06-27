using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;

namespace CapaVista
{
    public partial class RegistroLimpiezaHabitacion : Form
    {
        private ReporteLimpiezaManager habitacionManager;
        public RegistroLimpiezaHabitacion()
        {
            InitializeComponent();
            habitacionManager = new ReporteLimpiezaManager();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegistroLimpiezaHabitacion_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void FormRegistroLimpieza_Load(object sender, EventArgs e)
        {

        }


        private void guna2Button2_Click(object sender, EventArgs e)
        {

            int idHabitacion = Convert.ToInt32(comboBoxNumHabitacion.SelectedValue);
            DateTime fecha = DateTime.Now;
            string estado = txtEstado.Text;
            string observaciones = txtObservaciones.Text;
            int idInventario = Convert.ToInt32(comboBoxInventario.SelectedValue);
            int idUsuario = Convert.ToInt32(comboBoxEmpleado.SelectedValue);

            ReporteLimpiezaManager reporteLimpiezaManager = new ReporteLimpiezaManager();
            reporteLimpiezaManager.InsertarReporteLimpieza(idHabitacion, fecha, estado, observaciones, idInventario, idUsuario);

            MessageBox.Show("Registro de limpieza realizado correctamente.");


        }
    }
}

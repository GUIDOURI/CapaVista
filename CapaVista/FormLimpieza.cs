using Hotel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class FormLimpieza : Form
    {
        public FormLimpieza()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            FrmMenu menuForm = new FrmMenu();
            menuForm.Show();
            this.Hide();
        }

        private void FormLimpieza_Load(object sender, EventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AbrirFormPanel(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void MostrarFormLogoAlCerrarForms(object sender, FormClosedEventArgs e)
        {
            AbrirFormPanel(new FrmMenu());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            RegistroLimpiezaHabitacion registrolimpieza = new RegistroLimpiezaHabitacion();
            registrolimpieza.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormPanel(registrolimpieza);
        }
    }
}

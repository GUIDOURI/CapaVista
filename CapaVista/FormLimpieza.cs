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
    }
}

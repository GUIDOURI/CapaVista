using CapaNegocio;
using CapaNegocio.Modelos;
using Hotel;

namespace CapaVista
{
    public partial class RegistroLimpArea : Form
    {
        public RegistroLimpArea()
        {
            InitializeComponent();
        }
        private void Form_Load(object sender, EventArgs e)
        {
            LoadDataGredview();
            ComboBoxCargarUbicaciones();
            ComboBoxCargarInventario();
            ComboBoxCargarEmpleados();
        }

        private void ComboBoxCargarEmpleados()
        {
            IList<Empleado> empleados = new NegocioEmpleado().ListarEmpleados();
            ComunesVista.CargarDatosComoBox<Empleado>(comboBoxEmpleado, empleados, "Id", "Nombre", "--Seleccione empleado--");
        }

        private void ComboBoxCargarInventario()
        {
            IList<Inventario> inventarios = new NegocioInventario().ListarInventario();
            ComunesVista.CargarDatosComoBox<Inventario>(comboBoxInventario, inventarios, "Id", "Nombre", "--Seleccione inventario--");
        }

        private void ComboBoxCargarUbicaciones()
        {
            IList<Ubicacion> ubicaciones = new NegocioUbicacion().ListarUbicaciones();
            ComunesVista.CargarDatosComoBox<Ubicacion>(CbxUbicacion, ubicaciones, "Id", "NombreLugar", "--Seleccione ubicación--");
        }

        private void LoadDataGredview()
        {
            dataGridView1.DataSource = new NegocioLimpiezaArea().ListaLimpiezaAreas();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            /*FrmMenu menuForm = new FrmMenu();
            menuForm.Show();
            this.Hide();
            FrmMenu menu = new FrmMenu();
            menu.FormClosed -= new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormPanel(menu);*/
        }

        //abrir los formularios en el principal
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
            RegistroLimpiezaHabitacion registroLimpiezaHabitacion = new RegistroLimpiezaHabitacion();
            registroLimpiezaHabitacion.FormClosed -= new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormPanel(registroLimpiezaHabitacion);
            //Al mostrar el registro se quedan los botones anteriores

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegLimpiezaArea_Click(object sender, EventArgs e)
        {
            int idUbicacion = Convert.ToInt32(CbxUbicacion.SelectedValue);
            int idInventario = Convert.ToInt32(comboBoxInventario.SelectedValue);
            int idUsuario = Convert.ToInt32(comboBoxEmpleado.SelectedValue);
            string obs = txtObservaciones.Text;

            if (idUbicacion <= 0)
            {
                MessageBox.Show("Seleccione ubicación.");
                return;
            }
            if (idInventario <= 0)
            {
                MessageBox.Show("Seleccione inventario.");
                return;
            }
            if (idUsuario <= 0)
            {
                MessageBox.Show("Seleccione usuario.");
                return;
            }

            LimpiezaArea limpiezaArea = new LimpiezaArea()
            {
                IdUbicacion = idUbicacion,
                IdInventario = idInventario,
                IdUsuario = idUsuario,
                Observacion = obs,
                FechaLimpieza = DateTime.Now
            };
            try
            {
                bool resp = new NegocioLimpiezaArea().InsertarLimpiezaArea(limpiezaArea);
                if (resp)
                {
                    LoadDataGredview();
                    LimpiarCampos();
                    MessageBox.Show("Registro de limpieza realizado correctamente.");
                }
                else
                {
                    MessageBox.Show("Registro de limpieza no guardo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            comboBoxEmpleado.ResetText();
            comboBoxInventario.ResetText();
            CbxUbicacion.ResetText();
            txtObservaciones.ResetText();
        }
    }
}

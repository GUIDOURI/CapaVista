using CapaNegocio;
using CapaNegocio.Modelos;

namespace CapaVista
{
    public partial class RegistroLimpiezaHabitacion : Form
    {
        private IList<Habitacion> habitacions;

        public RegistroLimpiezaHabitacion()
        {
            InitializeComponent();
            habitacions = new NegocioHabitacion().ListarHabitaciones();
        }

        private void RegistroLimpiezaHabitacion_Load(object sender, EventArgs e)
        {
            LoadDataGredview();
            ComboBoxCargarNroHabitaciones();
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

        private void ComboBoxCargarNroHabitaciones()
        {
            ComunesVista.CargarDatosComoBox<Habitacion>(comboBoxNumHabitacion, habitacions, "Id", "Nro", "--Seleccione habitacion--");
        }

        private void LimpiarCampos()
        {
            comboBoxEmpleado.ResetText();
            comboBoxInventario.ResetText();
            comboBoxNumHabitacion.ResetText();
            txtEstado.ResetText();
            txtObservaciones.ResetText();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string idHabitacion = comboBoxNumHabitacion.SelectedValue.ToString();
                DateTime fecha = DateTime.Now;
                string estado = txtEstado.Text;
                string observaciones = txtObservaciones.Text;
                int idInventario = Convert.ToInt32(comboBoxInventario.SelectedValue);
                int idUsuario = Convert.ToInt32(comboBoxEmpleado.SelectedValue);

                if (string.IsNullOrEmpty(idHabitacion))
                {
                    MessageBox.Show("Seleccione una habitación.");
                    return;
                }
                if (string.IsNullOrEmpty(estado))
                {
                    MessageBox.Show("Proporcione un estado.");
                    return;
                }
                if (idInventario <= 0)
                {
                    MessageBox.Show("Seleccione inventario.");
                    return;
                }
                if (idUsuario <= 0)
                {
                    MessageBox.Show("Seleccione un empleado.");
                    return;
                }

                Limpieza limpieza = new Limpieza()
                {
                    IdHabitacion = idHabitacion,
                    FechaLimpieza = fecha,
                    Observaciones = observaciones,
                    IdInventario = idInventario,
                    IdUsuario = idUsuario,
                    Estado = estado
                };

                NegocioLimpieza reporteLimpiezaManager = new NegocioLimpieza();

                try
                {
                    bool resp = reporteLimpiezaManager.InsertarReporteLimpieza(limpieza);
                    if (resp)
                    {
                        LoadDataGredview();
                        LimpiarCampos();
                        MessageBox.Show("Registro de limpieza realizado correctamente.");
                        // throw new Exception("Error de prueba");
                    }
                    else
                    {
                        MessageBox.Show("Registro de limpieza no guardo.");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ha ocurrido un error\n" + ex.Message);
                }
            }
            catch (Exception) { }
        }

        private void LoadDataGredview()
        {
            NegocioLimpieza reporteLimpiezaManager = new NegocioLimpieza();
            dataGridView1.DataSource = reporteLimpiezaManager.ListaReporteLimpieza();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
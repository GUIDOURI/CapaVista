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


        private void guna2Button2_Click(object sender, EventArgs e)
        {

            string idHabitacion = comboBoxNumHabitacion.SelectedValue.ToString();
            DateTime fecha = DateTime.Now;
            string estado = txtEstado.Text;
            string observaciones = txtObservaciones.Text;
            int idInventario = Convert.ToInt32(comboBoxInventario.SelectedValue);
            int idUsuario = Convert.ToInt32(comboBoxEmpleado.SelectedValue);

            Limpieza limpieza = new Limpieza()
            {
                IdHabitacion = idHabitacion,
                FechaLimpieza = fecha,
                Observaciones = observaciones,
                IdInventario = idInventario,
                IdUsuario = idUsuario
            };

            ReporteLimpiezaManager reporteLimpiezaManager = new ReporteLimpiezaManager();
           
            try {
                bool resp = reporteLimpiezaManager.InsertarReporteLimpieza(limpieza);
                if (resp)
                {
                    LoadDataGredview();
                    MessageBox.Show("Registro de limpieza realizado correctamente.");
                }
                else
                {
                    MessageBox.Show("Registro de limpieza no guardo.");
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void LoadDataGredview()
        {
            ReporteLimpiezaManager reporteLimpiezaManager = new ReporteLimpiezaManager();
            dataGridView1.DataSource = reporteLimpiezaManager.ListaReporteLimpieza();
        }
    }
}

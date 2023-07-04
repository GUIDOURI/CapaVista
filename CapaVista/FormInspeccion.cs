using CapaNegocio.Modelos;
using CapaNegocio;

namespace CapaVista
{
    public partial class FormInspeccion : Form
    {

        public FormInspeccion()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int idHabitacion = Convert.ToInt32(comboBoxNumHabitacion.SelectedValue);
            int idUbicaciones = Convert.ToInt32(comboBoxIDarea.SelectedValue);

            if (idHabitacion <= 0)
            {
                MessageBox.Show("Seleccione ubicación.");
                return;
            }
            if (idUbicaciones <= 0)
            {
                MessageBox.Show("Seleccione inventario.");
                return;
            }


            Inspeccion limpiezaArea = new Inspeccion()
            {
                IdUbicacion = idUbicaciones,
                IdHabitacion = idHabitacion
            };
            try
            {
                bool resp = new NegocioInspeccion().InsertarInspecciones(limpiezaArea);
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
            comboBoxNumHabitacion.ResetText();
            comboBoxIDarea.ResetText();

        }

        private void LoadDataGredview()
        {
            dataGridView1.DataSource = new NegocioInspeccion().ListaInspeccion();
        }

        private void FormInspeccion_Load(object sender, EventArgs e)
        {
            LoadDataGredview();
            ComboBoxCargarNroHabitaciones();
            ComboBoxCargarUbicaciones();
        }


        private void ComboBoxCargarNroHabitaciones()
        {
            IList<Limpieza> habitacions = new NegocioLimpieza().ListarTablaLimpieza();
            ComunesVista.CargarDatosComoBox<Limpieza>(comboBoxNumHabitacion, habitacions, "Id", "Observaciones", "--Seleccione habitacion--");
        }

        private void ComboBoxCargarUbicaciones()
        {
            IList<LimpiezaArea> ubicaciones = new NegocioLimpiezaArea().ListarTablaLimpieza();
            ComunesVista.CargarDatosComoBox<LimpiezaArea>(comboBoxIDarea, ubicaciones, "Id", "Observacion", "--Seleccione ubicación--");
        }
    }
}
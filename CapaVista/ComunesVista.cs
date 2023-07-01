namespace CapaVista
{
    public class ComunesVista
    {
        public static void CargarDatosComoBox<T>(ComboBox combo, IList<T> coleccion, string valor, string mostrar, string inicio) 
        {
            //var bindinList = new BindingList(coleccion);
            combo.DataSource = coleccion;
            combo.ValueMember = valor;
            combo.DisplayMember = mostrar;
            combo.SelectedIndex = -1;
            combo.SelectedText = inicio;
            //combo.ResetText();
        }
    }
}

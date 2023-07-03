namespace CapaDatos.Clases
{
    internal class Habitacion
    {
        private int Idhabitacion;

        public int IDHabitacion
        {
            get { return Idhabitacion; }
            set { Idhabitacion = value; }
        }

        private int piso;

        public int Piso
        {
            get { return piso; }
            set { piso = value; }
        }

        private string tipoHabitacion;

        public string TipoHabitacion
        {
            get { return tipoHabitacion; }
            set { tipoHabitacion = value; }
        }

        private string NumHabitacion;

        public string NUMHabitacion
        {
            get { return NumHabitacion; }
            set { NumHabitacion = value; }
        }

        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private int precio;

        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }
    }
}
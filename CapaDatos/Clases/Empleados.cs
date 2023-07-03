namespace CapaDatos.Clases
{
    internal class Empleados : Persona
    {
        private int idUsuario;

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        private Byte foto;

        public Byte Foto
        {
            get { return foto; }
            set { foto = value; }
        }

        private string usuario;

        public string Usuarios
        {
            get { return usuario; }
            set { usuario = value; }
        }

        private string contrasena;

        public string Contrasena
        {
            get { return contrasena; }
            set { contrasena = value; }
        }
    }
}
namespace CapaNegocio.Modelos
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Ci { get; set; }
        public string Usuario { get; set; }
        public int IdRol { get; set; }
        public string Estado { get; set; }
    }
}
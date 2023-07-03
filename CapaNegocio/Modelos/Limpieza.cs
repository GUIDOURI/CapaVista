namespace CapaNegocio.Modelos
{
    public class Limpieza
    {
        public int Id { get; set; }
        public string IdHabitacion { get; set; }
        public DateTime FechaLimpieza { get; set; }
        public string Observaciones { get; set; }
        public int IdInventario { get; set; }
        public int IdUsuario { get; set; }
        public string Estado { get; set; }
    }
}
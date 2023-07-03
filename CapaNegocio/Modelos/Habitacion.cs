namespace CapaNegocio.Modelos
{
    public class Habitacion
    {
        public string Id { get; set; }
        public string Nro { get; set; }
        public int IdTipoHabitacion { get; set; }
        public decimal Precio { get; set; }
        public string Estado { get; set; }
    }
}
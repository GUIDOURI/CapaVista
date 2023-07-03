namespace CapaNegocio.Modelos
{
    public class LimpiezaArea
    {
        public int Id { get; set; }
        public int IdUbicacion { get; set; }
        public int IdInventario { get; set; }
        public int IdUsuario { get; set; }
        public string Observacion { get; set; }
        public DateTime FechaLimpieza { get; set; }
    }
}

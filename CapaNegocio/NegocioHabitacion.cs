using CapaDatos;
using CapaNegocio.Modelos;
using System.Data;

namespace CapaNegocio
{
    public class NegocioHabitacion
    {
        public IList<Habitacion> ListarHabitaciones() { 
            IList<Habitacion> habitaciones = new List<Habitacion>();

            DataTable dt = new HabitacionDAO().ObtenerHabitaciones();

            habitaciones = Comunes.ConvertDataTable<Habitacion>(dt);

            return habitaciones;
        }
    }
}

using CapaDatos;
using CapaNegocio.Modelos;
using System.Data;

namespace CapaNegocio
{
    public class NegocioUbicacion
    {
        public IList<Ubicacion> ListarUbicaciones()
        {
            IList<Ubicacion> ubic = new List<Ubicacion>();

            DataTable dt = new UbicacionDAO().ObtenerUbicaciones();

            ubic = Comunes.ConvertDataTable<Ubicacion>(dt);

            return ubic;
        }
    }
}

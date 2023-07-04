using CapaDatos;
using CapaNegocio.Modelos;
using System.Data;

namespace CapaNegocio
{
    public class NegocioLimpieza
    {
        public NegocioLimpieza()
        {
        }

        public bool InsertarReporteLimpieza(Limpieza limpieza)
        {
            bool resp = new LimpiezaHabitacionDAO().GuardarLimpieza(limpieza.IdHabitacion, limpieza.FechaLimpieza, limpieza.Observaciones, limpieza.IdInventario, limpieza.IdUsuario, limpieza.Estado);

            return resp;
        }

    
        public DataTable ListaReporteLimpieza()
        {
            IList<Limpieza> empleados = new List<Limpieza>();

            DataTable dt = new LimpiezaHabitacionDAO().ListaReportesLimpieza();

            empleados = Comunes.ConvertDataTable<Limpieza>(dt);

            return dt;
        }

        public IList<Limpieza> ListarTablaLimpieza()
        {
            IList<Limpieza> empleados = new List<Limpieza>();

            DataTable dt = new LimpiezaHabitacionDAO().ListarTablaLimpieza();

            empleados = Comunes.ConvertDataTable<Limpieza>(dt);

            return empleados;
        }
    }
}
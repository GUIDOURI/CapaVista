using CapaDatos;
using CapaNegocio.Modelos;
using System.Data;

namespace CapaNegocio
{
    public class ReporteLimpiezaManager
    {
        public ReporteLimpiezaManager()
        {
            
        }

        public bool InsertarReporteLimpieza(Limpieza limpieza)
        {        

            bool resp = new LimpiezaHabitacionDAO().GuardarLimpieza(limpieza.IdHabitacion, limpieza.FechaLimpieza, limpieza.Observaciones, limpieza.IdInventario, limpieza.IdUsuario, limpieza.Estado);

            return resp;
        }

        public DataTable ListaReporteLimpieza()
        {
            return new LimpiezaHabitacionDAO().ListaReportesLimpieza();
        }
    }
}

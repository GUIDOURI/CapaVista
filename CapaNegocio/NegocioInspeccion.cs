using CapaDatos;
using CapaNegocio.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NegocioInspeccion
    {
        public bool InsertarInspecciones(Inspeccion inspeccion)
        {
            bool resp = new InspeccionDAO().RegistrarInspeccion(inspeccion.IdHabitacion,inspeccion.IdUbicacion, DateTime.Now);

            return resp;
        }

        public DataTable ListaInspeccion()
        {
            return new InspeccionDAO().ListaInspeccion();
        }
    }
}

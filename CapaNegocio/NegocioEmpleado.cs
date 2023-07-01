using CapaDatos;
using CapaNegocio.Modelos;
using System.Data;

namespace CapaNegocio
{
    public class NegocioEmpleado
    {
        public IList<Empleado> ListarEmpleados()
        {
            IList<Empleado> empleados = new List<Empleado>();

            DataTable dt = new EmpleadoDAO().ObtenerEmpleados();

            empleados = Comunes.ConvertDataTable<Empleado>(dt);

            return empleados;
        }
    }
}

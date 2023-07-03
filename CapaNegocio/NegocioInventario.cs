using CapaDatos;
using CapaNegocio.Modelos;
using System.Data;

namespace CapaNegocio
{
    public class NegocioInventario
    {
        public IList<Inventario> ListarInventario()
        {
            IList<Inventario> inventarios = new List<Inventario>();

            DataTable dt = new InventarioDAO().ObtenerInventario();

            inventarios = Comunes.ConvertDataTable<Inventario>(dt);

            return inventarios;
        }
    }
}
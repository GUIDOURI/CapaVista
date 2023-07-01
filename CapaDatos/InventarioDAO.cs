using System.Data;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class InventarioDAO : BaseDAO
    {        
        public DataTable ObtenerInventario()
        {
            MySqlConnection connection = conexion.ObtenerConexion();
            DataTable dtInventario = new DataTable();

            try
            {
                connection.Open();

                string query = "SELECT id_inventario Id, nombre_objeto Nombre, cantidad Cantidad, fecha Fecha FROM inventario";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dtInventario);
            }
            catch (MySqlException ex)
            {
                // Manejo de excepciones
                Console.WriteLine("Error al consultar inventario: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dtInventario;
        }
    }
}

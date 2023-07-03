using MySql.Data.MySqlClient;
using System.Data;

namespace CapaDatos
{
    public class UbicacionDAO: BaseDAO
    {
        public DataTable ObtenerUbicaciones()
        {
            MySqlConnection connection = conexion.ObtenerConexion();
            DataTable dt = new DataTable();

            try
            {
                connection.Open();

                string query = "SELECT id_ubicacion Id, nombre_lugar NombreLugar, tipo Tipo FROM ubicacion";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dt);
            }
            catch (MySqlException ex)
            {
                // Manejo de excepciones
                Console.WriteLine("Error al consultar ubicaciones: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }
    }
}

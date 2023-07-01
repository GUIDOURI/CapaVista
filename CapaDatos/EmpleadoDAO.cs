using MySql.Data.MySqlClient;
using System.Data;

namespace CapaDatos
{
    public class EmpleadoDAO : BaseDAO
    {
        public DataTable ObtenerEmpleados()
        {
            MySqlConnection connection = conexion.ObtenerConexion();
            DataTable dtHabitaciones = new DataTable();

            try
            {
                connection.Open();

                string query = "SELECT id_usuario Id, CONCAT(nombre, ' ', apellidos) Nombre, ci Ci, id_rol IdRol, estado Estado FROM usuario";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dtHabitaciones);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error al obtener las habitaciones: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dtHabitaciones;
        }
    }
}


using MySql.Data.MySqlClient;
using System.Data;

namespace CapaDatos
{
    public class HabitacionDAO : BaseDAO
    {
        public DataTable ObtenerHabitaciones()
        {
            MySqlConnection connection = conexion.ObtenerConexion();
            DataTable dtHabitaciones = new DataTable();

            try
            {
                connection.Open();

                string query = "SELECT id_habitacion Id, numhabitacion Nro, id_tipohabitacion IdTipoHabitacion, precio Precio, estado Estado FROM habitacion";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(dtHabitaciones);
            }
            catch (MySqlException ex)
            {
                // Manejo de excepciones
                Console.WriteLine("Error al obtener las habitaciones: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dtHabitaciones;
        }

        // Resto del código de la clase HabitacionDAO
    }
}
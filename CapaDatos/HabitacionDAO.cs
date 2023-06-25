using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class HabitacionDAO
    {

        private Conexion conexion;

        public HabitacionDAO()
        {
            conexion = new Conexion();
        }

        public DataTable ObtenerHabitaciones()
        {
            MySqlConnection connection = conexion.ObtenerConexion();
            DataTable dtHabitaciones = new DataTable();

            try
            {
                connection.Open();

                string query = "SELECT id_habitacion, num_habitacion FROM habitacion";
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

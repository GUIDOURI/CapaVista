using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    internal class Class_limpieza_habitacion
    {
        private string connectionString = "server=localhost;database=amadellaves;user=root;password='';"; 

        public void RegistrarLimpiezaHabitacion(DateTime fecha, int idHabitacion)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Obtener el último ID de limpieza
                int ultimoID = ObtenerUltimoIDLimpieza(connection);

                // Generar el nuevo ID sumando 1 al último ID
                int nuevoID = ultimoID + 1;

                // Insertar el nuevo registro de limpieza
                string query = "INSERT INTO registro_limpieza_habitacion (ID_limpieza, Fecha, id_habitacion) VALUES (@idLimpieza, @fecha, @idHabitacion)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@idLimpieza", nuevoID);
                command.Parameters.AddWithValue("@fecha", fecha);
                command.Parameters.AddWithValue("@idHabitacion", idHabitacion);
                command.ExecuteNonQuery();

                // Actualizar el estado de la habitación a "limpia"
                ActualizarEstadoHabitacion(connection, idHabitacion, "limpia");

                Console.WriteLine("Se ha registrado la limpieza de la habitación correctamente.");

                connection.Close();
            }
        }

        private int ObtenerUltimoIDLimpieza(MySqlConnection connection)
        {
            string query = "SELECT MAX(ID_limpieza) FROM registro_limpieza_habitacion";
            MySqlCommand command = new MySqlCommand(query, connection);
            object result = command.ExecuteScalar();
            return (result != DBNull.Value) ? Convert.ToInt32(result) : 80000; // Si no hay registros, se devuelve 80000 como valor predeterminado
        }

        private void ActualizarEstadoHabitacion(MySqlConnection connection, int idHabitacion, string estado)
        {
            string query = "UPDATE habitaciones SET estado = @estado WHERE id_habitacion = @idHabitacion";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@estado", estado);
            command.Parameters.AddWithValue("@idHabitacion", idHabitacion);
            command.ExecuteNonQuery();
        }
    }
}

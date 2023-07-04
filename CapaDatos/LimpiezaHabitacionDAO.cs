using MySql.Data.MySqlClient;
using System.Data;

namespace CapaDatos
{
    public class LimpiezaHabitacionDAO : BaseDAO
    {
        public void RegistrarLimpiezaHabitacion(DateTime fecha, int idHabitacion)
        {
            using (MySqlConnection connection = conexion.ObtenerConexion())
            {
                connection.Open();

                // Obtener el último ID de limpieza
                int ultimoID = ObtenerUltimoIDLimpieza(connection);

                // Generar el nuevo ID sumando 1 al último ID
                int nuevoID = ultimoID + 1;

                // Insertar el nuevo registro de limpieza
                string query = "INSERT INTO reporte_limpiezas(ID_limpieza, Fecha, id_habitacion) VALUES (@idLimpieza, @fecha, @idHabitacion)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@idLimpieza", nuevoID);
                command.Parameters.AddWithValue("@fecha", fecha);
                command.Parameters.AddWithValue("@idHabitacion", idHabitacion);
                command.ExecuteNonQuery();

                // Actualizar el estado de la habitación a "limpia"
                ActualizarEstadoHabitacion(idHabitacion.ToString(), "limpia");

                Console.WriteLine("Se ha registrado la limpieza de la habitación correctamente.");

                connection.Close();
            }
        }

        private int ObtenerUltimoIDLimpieza(MySqlConnection connection)
        {
            string query = "SELECT MAX(id_reporte) FROM reporte_limpieza";
            MySqlCommand command = new MySqlCommand(query, connection);
            object result = command.ExecuteScalar();
            return (result != DBNull.Value) ? Convert.ToInt32(result) : 80000; // Si no hay registros, se devuelve 80000 como valor predeterminado
        }

        private void ActualizarEstadoHabitacion(string idHabitacion, string estado)
        {
            string query = "UPDATE habitacion SET estado = @estado WHERE id_habitacion = @idHabitacion";
            MySqlCommand command = new MySqlCommand(query, conexion.ObtenerConexion());
            command.Parameters.AddWithValue("@estado", estado);
            command.Parameters.AddWithValue("@idHabitacion", idHabitacion);
            command.ExecuteNonQuery();
        }

        public bool GuardarLimpieza(string idHabitacion, DateTime fechaLimpieza, string observaciones, int idInventario, int idUsuario, string estado)
        {
            bool result = false;
            using (MySqlConnection connection = conexion.ObtenerConexion())
            {
                try
                {
                    connection.Open();

                    // Obtener el último ID de limpieza
                    int ultimoID = ObtenerUltimoIDLimpieza(connection);

                    // Generar el nuevo ID sumando 1 al último ID
                    int nuevoID = ultimoID + 1;

                    // Insertar el nuevo registro de limpieza
                    string query = "INSERT INTO reporte_limpieza(id_reporte, id_habitacion, FechaLimpieza, Observaciones, id_inventario, id_usuario) VALUES (@id, @idHabitacion, @fechaLimpieza, @observaciones, @idInventario, @idUsuario)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", nuevoID);
                    command.Parameters.AddWithValue("@idHabitacion", idHabitacion);
                    command.Parameters.AddWithValue("@fechaLimpieza", fechaLimpieza);
                    command.Parameters.AddWithValue("@observaciones", observaciones);
                    command.Parameters.AddWithValue("@idInventario", idInventario);
                    command.Parameters.AddWithValue("@idUsuario", idUsuario);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        // Actualizar el estado de la habitación a "limpia"
                        ActualizarEstadoHabitacion(idHabitacion, estado);
                        result = true;
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al registrar reporte de limpieza: " + ex.Message);
                }
            }
            return result;
        }

        public DataTable ListaReportesLimpieza()
        {
            MySqlConnection connection = conexion.ObtenerConexion();
            DataTable dtHabitaciones = new DataTable();

            try
            {
                connection.Open();

                string query = @$"SELECT h.numhabitacion, rl.FechaLimpieza, h.estado, inv.nombre_objeto, CONCAT(usr.nombre, ' ', usr.apellidos) empleado, rl.Observaciones
                                from reporte_limpieza rl
                                INNER JOIN habitacion h on rl.id_habitacion = h.id_habitacion
                                INNER JOIN inventario inv on rl.id_inventario = inv.id_inventario
                                INNER JOIN usuario usr on rl.id_usuario = usr.id_usuario";
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

        public DataTable ListarTablaLimpieza()
        {
            MySqlConnection connection = conexion.ObtenerConexion();
            DataTable dtHabitaciones = new DataTable();

            try
            {
                connection.Open();

                string query = @$"SELECT id_reporte Id, Observaciones FROM reporte_limpieza ";
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
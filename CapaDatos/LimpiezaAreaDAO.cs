using MySql.Data.MySqlClient;
using System.Data;

namespace CapaDatos
{
    public class LimpiezaAreaDAO: BaseDAO
    {
        public bool GuardarLimpiezaArea(int idUbicacion, int idInventario, int idUsuario, string observacion, DateTime fechaLimpieza)
        {
            bool result = false;
            using (MySqlConnection connection = conexion.ObtenerConexion())
            {
                try
                {
                    connection.Open();

                    int ultimoID = ObtenerUltimoIDLimpiezaArea(connection);

                    int nuevoID = ultimoID + 1;

                    string query = "INSERT INTO limpieza_areas(id_limpieza_area, id_ubicacion, id_inventario, id_usuario, ObservacionesArea, FechaLimpiezaArea) VALUES (@id, @idUbicacion, @idInventario, @idUsuario, @observacion, @fechaLimpieza)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", nuevoID);
                    command.Parameters.AddWithValue("@idUbicacion", idUbicacion);
                    command.Parameters.AddWithValue("@idInventario", idInventario);
                    command.Parameters.AddWithValue("@idUsuario", idUsuario);
                    command.Parameters.AddWithValue("@observacion", observacion);
                    command.Parameters.AddWithValue("@fechaLimpieza", fechaLimpieza);
                    if (command.ExecuteNonQuery() > 0)
                    {                        
                        result = true;
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al registrar reporte de limpieza de area: " + ex.Message);
                }

            }
            return result;
        }

        private int ObtenerUltimoIDLimpiezaArea(MySqlConnection connection)
        {
            string query = "SELECT MAX(id_limpieza_area) FROM limpieza_areas";
            MySqlCommand command = new MySqlCommand(query, connection);
            object result = command.ExecuteScalar();
            return (result != DBNull.Value) ? Convert.ToInt32(result) : 90000;
        }

        public DataTable ListaLimpiezaAreas()
        {
            MySqlConnection connection = conexion.ObtenerConexion();
            DataTable dtHabitaciones = new DataTable();

            try
            {
                connection.Open();

                string query = @$"select la.id_limpieza_area Id, ub.nombre_lugar Ubicacion, inv.nombre_objeto Inventario, CONCAT(usr.nombre, ' ', usr.apellidos) Empleado, la.ObservacionesArea, la.FechaLimpiezaArea
from limpieza_areas la
inner JOIN ubicacion ub on la.id_ubicacion = ub.id_ubicacion
inner JOIN inventario inv on la.id_inventario = inv.id_inventario
INNER JOIN usuario usr on la.id_usuario = usr.id_usuario";
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

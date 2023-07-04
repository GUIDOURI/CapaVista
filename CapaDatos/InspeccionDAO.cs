using CapaDatos.Clases;
using MySql.Data.MySqlClient;
using System.Data;


namespace CapaDatos
{
    public class InspeccionDAO : BaseDAO
    {
        public DataTable ListaInspeccion()
        {
            MySqlConnection connection = conexion.ObtenerConexion();
            DataTable dtHabitaciones = new DataTable();

            try
            {
                connection.Open();

                string query = $@"SELECT h.numhabitacion, rl.id_inventario, rl.Observaciones, la.id_limpieza_area, la.id_inventario, la.ObservacionesArea, ins.FechaInspeccion
FROM inspeccion ins 
INNER JOIN reporte_limpieza rl ON ins.id_reporte = rl.id_reporte 
INNER JOIN habitacion h ON rl.id_habitacion = h.id_habitacion
INNER JOIN limpieza_areas la ON ins.ID_limpieza_area = la.id_limpieza_area";
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

        public DataTable ObtenerHabitacionesInsp()
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



        public bool RegistrarInspeccion( int id_reportH, int id_ubicacion, DateTime fechaInspec)
        {

            bool ri = false;

            using (MySqlConnection connection = conexion.ObtenerConexion())
            {
                try
                {
                    connection.Open();
                    int ultimoID = ObtenerUltimoIdInspeccion(connection);
                    int nuevoID = ultimoID + 1;

                    string query = "INSERT INTO inspeccion (id_inspeccion, id_reporte, ID_limpieza_area, FechaInspeccion) VALUES (@iD_inspeccion, @idReporte, @id_limpiezaHabitacion, @fecha)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@iD_inspeccion", nuevoID);
                    command.Parameters.AddWithValue("@idReporte", id_reportH);
                    command.Parameters.AddWithValue("@id_limpiezaHabitacion", id_ubicacion);
                    command.Parameters.AddWithValue("@fecha", fechaInspec);
                    if (command.ExecuteNonQuery() > 0)
                    {
                        ri = true;
                        Console.WriteLine("Se ha registrado la Inspeccion correctamente.");
                    }
                
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al registrar INSPECCION: " + ex.Message);
                }
                return ri;

            }
        }

        private int ObtenerUltimoIdInspeccion(MySqlConnection connection)
        {
            string query = "SELECT MAX(id_inspeccion) FROM inspeccion";
            MySqlCommand command = new MySqlCommand(query, connection);
            object result = command.ExecuteScalar();
            return (result != DBNull.Value) ? Convert.ToInt32(result) : 50000; // Si no hay registros, se devuelve 50000 como valor predeterminado
        }

    }
}


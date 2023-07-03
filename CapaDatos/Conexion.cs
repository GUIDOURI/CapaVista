using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace CapaDatos
{
    public class Conexion
    {
        private string CadenaConexion;
        private MySqlConnection conexion;

        public Conexion()
        {
            // Cadena de conexión a la base de datos
            string servidor = "localhost";
            string baseDatos = "hotel_amallaves";
            string usuario = "root";
            string contrasena = "";
            //CadenaConexion = $"server={servidor};database={baseDatos};uid={usuario};pwd={contrasena};";
            CadenaConexion = ConfigurationManager.ConnectionStrings["mysql"].ConnectionString;

            // Crear objeto MySqlConnection
            conexion = new MySqlConnection(CadenaConexion);
        }

        public MySqlConnection ObtenerConexion()
        {
            return conexion;
        }

        public void AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
        }

        public void CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
        }

        public void Dispose()
        {
            if (conexion != null)
            {
                conexion.Dispose();
            }
        }

        public void InsertarReporteLimpieza(int idHabitacion, DateTime fecha, string estado, string observaciones, int idInventario, int idUsuario)
        {
            string query = "INSERT INTO reporte_limpieza (id_habitacion, Fecha, estado, Observaciones, id_inventario, id_usuario) " +
                           "VALUES (@idHabitacion, @fecha, @estado, @observaciones, @idInventario, @idUsuario)";

            using (MySqlCommand command = new MySqlCommand(query, conexion))
            {
                command.Parameters.AddWithValue("@idHabitacion", idHabitacion);
                command.Parameters.AddWithValue("@fecha", fecha);
                command.Parameters.AddWithValue("@estado", estado);
                command.Parameters.AddWithValue("@observaciones", observaciones);
                command.Parameters.AddWithValue("@idInventario", idInventario);
                command.Parameters.AddWithValue("@idUsuario", idUsuario);

                AbrirConexion();
                command.ExecuteNonQuery();
                CerrarConexion();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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
            CadenaConexion = $"server={servidor};database={baseDatos};uid={usuario};pwd={contrasena};";

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


       
    }
}

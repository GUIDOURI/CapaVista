using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    internal class Inspeccion : BaseDAO
    {
        public void RegistrarInspeccion( int idHabitacion, int idUbicacion, DateTime fecha)
        {


            using (MySqlConnection connection = conexion.ObtenerConexion())
            {
                connection.Open();
                int ultimoID = ObtenerUltimoIdInspeccion(connection);
                int nuevoID = ultimoID + 1;



                Console.WriteLine("Se ha registrado la Inspeccion correctamente.");

                connection.Close();
            }
        }

        private int ObtenerUltimoIdInspeccion(MySqlConnection connection)
        {
            string query = "SELECT MAX(id_inspeccion) FROM inspeccion";
            MySqlCommand command = new MySqlCommand(query, connection);
            object result = command.ExecuteScalar();
            return (result != DBNull.Value) ? Convert.ToInt32(result) : 50000; // Si no hay registros, se devuelve 80000 como valor predeterminado
        }


    }
}

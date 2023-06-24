using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace CapaNegocio
{
    public class NegocioUsuario
    {
        private Conexion conexion = new Conexion();

        public bool ValidarUsuario(string usuario, string contrasena)
        {
            string contrasenaEncriptada = EncriptarContrasena(contrasena);

            using (MySqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM usuario WHERE usuario = @usuario AND contrasena = @contrasena";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contrasena", contrasenaEncriptada);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count > 0;
            }
        }

        private string EncriptarContrasena(string contrasena)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(contrasena);
                byte[] hash = sha256.ComputeHash(bytes);
                StringBuilder builder = new StringBuilder();
                foreach (byte b in hash)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}

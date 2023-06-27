using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using MySql.Data.MySqlClient;


namespace CapaNegocio
{
    public class ReporteLimpiezaManager
    {
        private Conexion conexion;

        public ReporteLimpiezaManager()
        {
            conexion = new Conexion();
        }

        public void InsertarReporteLimpieza(int idHabitacion, DateTime fecha, string estado, string observaciones, int idInventario, int idUsuario)
        {
            conexion.InsertarReporteLimpieza(idHabitacion, fecha, estado, observaciones, idInventario, idUsuario);
        }
    }
}

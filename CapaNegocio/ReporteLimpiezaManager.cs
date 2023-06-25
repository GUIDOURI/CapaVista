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
        private HabitacionDAO habitacionDAO;

        public ReporteLimpiezaManager()
        {
            habitacionDAO = new HabitacionDAO();
        }

        public DataTable ObtenerHabitaciones()
        {
            return habitacionDAO.ObtenerHabitaciones();
        }

        // Resto del código de la clase HabitacionManager
    }
}

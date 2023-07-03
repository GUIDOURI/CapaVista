namespace CapaDatos
{
    public class BaseDAO
    {
        internal Conexion conexion;

        public BaseDAO()
        {
            conexion = new Conexion();
        }
    }
}
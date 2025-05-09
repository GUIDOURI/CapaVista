﻿using CapaDatos;
using CapaNegocio.Modelos;
using System.Data;

namespace CapaNegocio
{
    public class NegocioLimpiezaArea
    {
        public bool InsertarLimpiezaArea(LimpiezaArea limpiezaArea)
        {
            bool resp = new LimpiezaAreaDAO().GuardarLimpiezaArea(limpiezaArea.IdUbicacion, limpiezaArea.IdInventario, limpiezaArea.IdUsuario, limpiezaArea.Observacion, limpiezaArea.FechaLimpieza);

            return resp;
        }

        public DataTable ListaLimpiezaAreas()
        {
            return new LimpiezaAreaDAO().ListaLimpiezaAreas();
        }
        public IList<LimpiezaArea> ListarTablaLimpieza()
        {
            IList<LimpiezaArea> empleados = new List<LimpiezaArea>();

            DataTable dt = new LimpiezaAreaDAO().ListarTablaLimpieza();

            empleados = Comunes.ConvertDataTable<LimpiezaArea>(dt);

            return empleados;
        }
    }
}
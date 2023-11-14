using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Compra
    {

        private CD_Compra objCD_Compra = new CD_Compra();


        public int ObtenerCorrelativo()
        {
            return objCD_Compra.ObtenerCorrelativo();
        }

        public bool Registrar(Compras obj, DataTable DetalleCompra, out string Mensaje)
        {
            return objCD_Compra.Registrar(obj, DetalleCompra, out Mensaje);
        }
    }
}

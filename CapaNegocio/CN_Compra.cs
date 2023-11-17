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

        public Compras ObtenerCompra(string numero)
        {
            Compras ocompra = objCD_Compra.ObteneCompra(numero);

            if(ocompra.Id_compra != 0)
            {
                List<Detalles_compras> odetallecompra = objCD_Compra.ObteneDetalleCompra(ocompra.Id_compra);

                ocompra.Odetalle_compra = odetallecompra;
            }
            return ocompra;
        }
    }
}

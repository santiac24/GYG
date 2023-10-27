using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Prendas
    {

        private CD_Prendas objCD_Prenda = new CD_Prendas();


        public List<Prendas> Listar()
        {
            return objCD_Prenda.Listar();
        }

        public int Registrar(Prendas obj, out string Mensaje)
        {
            Mensaje = "";

            if (obj.Prenda == "")
            {
                Mensaje += "Es necesario el nombre de la prenda";
            }

            if (obj.Precio_venta == 0)
            {
                Mensaje += "No se acepta el precio de venta en 0";
            }
            if (obj.Precio_compra == 0)
            {
                Mensaje += "No se acepta el precio de compra en 0";
            }

            //Si no se han cumplido las reglas de negocio, no debería llamar al método registrar
            if (Mensaje != "")
            {
                return 0;
            }
            else
            {
                return objCD_Prenda.Regitrar(obj, out Mensaje);
            }

        }

        public bool Editar(Prendas obj, out string Mensaje)
        {
            Mensaje = "";
            if (obj.Prenda == "")
            {
                Mensaje += "Es necesario el nombre de la prenda";
            }

            if (obj.Precio_venta == 0)
            {
                Mensaje += "No se acepta el precio de venta en 0";
            }
            if (obj.Precio_compra == 0)
            {
                Mensaje += "No se acepta el precio de compra en 0";
            }

            //Si no se han cumplido las reglas de negocio, no debería llamar al método registrar
            if (Mensaje != "")
            {
                return false;
            }
            else
            {
                return objCD_Prenda.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Prendas obj, out string Mensaje)
        {
            return objCD_Prenda.Eliminar(obj, out Mensaje);
        }
    }
}

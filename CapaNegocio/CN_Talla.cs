using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Talla
    {

        private CD_Talla objcd_Tallas = new CD_Talla();


        public List<Tallas> Listar()
        {
            return objcd_Tallas.Listar();
        }

        public int Registrar(Tallas obj, out string Mensaje)
        {
            Mensaje = "";

            if (obj.Talla == "")
            {
                Mensaje += "Es necesario la talla";
            }

            //Si no se han cumplido las reglas de negocio, no debería llamar al método registrar
            if (Mensaje != "")
            {
                return 0;
            }
            else
            {
                return objcd_Tallas.Regitrar(obj, out Mensaje);
            }

        }

        public bool Editar(Tallas obj, out string Mensaje)
        {
            Mensaje = "";
            if (obj.Talla == "")
            {
                Mensaje += "Es necesario la talla";
            }


            //Si no se han cumplido las reglas de negocio, no debería llamar al método registrar
            if (Mensaje != "")
            {
                return false;
            }
            else
            {
                return objcd_Tallas.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Tallas obj, out string Mensaje)
        {
            return objcd_Tallas.Eliminar(obj, out Mensaje);
        }
    }
}

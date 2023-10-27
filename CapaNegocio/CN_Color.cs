using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Color
    {

        private CD_Color objcd_Colores = new CD_Color();


        public List<Colores> Listar()
        {
            return objcd_Colores.Listar();
        }

        public int Registrar(Colores obj, out string Mensaje)
        {
            Mensaje = "";

            if (obj.Color == "")
            {
                Mensaje += "Es necesario el color";
            }

            //Si no se han cumplido las reglas de negocio, no debería llamar al método registrar
            if (Mensaje != "")
            {
                return 0;
            }
            else
            {
                return objcd_Colores.Regitrar(obj, out Mensaje);
            }

        }

        public bool Editar(Colores obj, out string Mensaje)
        {
            Mensaje = "";
            if (obj.Color == "")
            {
                Mensaje += "Es necesario el color";
            }


            //Si no se han cumplido las reglas de negocio, no debería llamar al método registrar
            if (Mensaje != "")
            {
                return false;
            }
            else
            {
                return objcd_Colores.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Colores obj, out string Mensaje)
        {
            return objcd_Colores.Eliminar(obj, out Mensaje);
        }
    }
}

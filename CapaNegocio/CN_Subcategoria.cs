using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Subcategoria
    {


        private CD_Subcategoria objCD_Subcategoria = new CD_Subcategoria();


        public List<SubCategorias> Listar()
        {
            return objCD_Subcategoria.Listar();
        }

        public int Registrar(SubCategorias obj, out string Mensaje)
        {
            Mensaje = "";

            if (obj.subcategoria == "")
            {
                Mensaje += "Es necesario el nombre de la Subcategoria";
            }

            //Si no se han cumplido las reglas de negocio, no debería llamar al método registrar
            if (Mensaje != "")
            {
                return 0;
            }
            else
            {
                return objCD_Subcategoria.Regitrar(obj, out Mensaje);
            }

        }

        public bool Editar(SubCategorias obj, out string Mensaje)
        {
            Mensaje = "";
            if (obj.subcategoria == "")
            {
                Mensaje += "Es necesario el nombre de la Subcategoria";
            }

            //Si no se han cumplido las reglas de negocio, no debería llamar al método registrar
            if (Mensaje != "")
            {
                return false;
            }
            else
            {
                return objCD_Subcategoria.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(SubCategorias obj, out string Mensaje)
        {
            return objCD_Subcategoria.Eliminar(obj, out Mensaje);
        }
    }
}

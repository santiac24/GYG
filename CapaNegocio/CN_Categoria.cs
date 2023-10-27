using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Categoria
    {
        private CD_Categoria objcd_Categoria = new CD_Categoria();


        public List<Categorias> Listar()
        {
            return objcd_Categoria.Listar();
        }

        public int Registrar(Categorias obj, out string Mensaje)
        {
            Mensaje = "";

            if (obj.Categoria == "")
            {
                Mensaje += "Es necesario el nombre de la categoria";
            }

            //Si no se han cumplido las reglas de negocio, no debería llamar al método registrar
            if (Mensaje != "")
            {
                return 0;
            }
            else
            {
                return objcd_Categoria.Regitrar(obj, out Mensaje);
            }

        }

        public bool Editar(Categorias obj, out string Mensaje)
        {
            Mensaje = "";
            if (obj.Categoria == "")
            {
                Mensaje += "Es necesario el nombre de la categoria";
            }


            //Si no se han cumplido las reglas de negocio, no debería llamar al método registrar
            if (Mensaje != "")
            {
                return false;
            }
            else
            {
                return objcd_Categoria.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Categorias obj, out string Mensaje)
        {
            return objcd_Categoria.Eliminar(obj, out Mensaje);
        }
    }
}

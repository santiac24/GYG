using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Usuario
    {
    	private CD_Usuario objcd_usuario = new CD_Usuario();
    	
    	
    	public List<Usuarios> Listar()
    	{
    		return objcd_usuario.Listar();
    	}

        public int Registrar(Usuarios obj, out string Mensaje)
        {
            Mensaje = "";

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre del usuario";
            }

            if (obj.Usuario == "")
            {
                Mensaje += "Es necesario el usario unico para identificar";
            }

            if (obj.Contrasena == "")
            {
                Mensaje += "Es necesario la clave del usuario";
            }

            //Si no se han cumplido las reglas de negocio, no debería llamar al método registrar
            if (Mensaje != "")
            {
                return 0;
            }
            else
            {
                return objcd_usuario.Regitrar(obj, out Mensaje);
            }

        }

        public bool Editar(Usuarios obj, out string Mensaje)
        {
            Mensaje = "";
            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre del usuario";
            }

            if (obj.Usuario == "")
            {
                Mensaje += "Es necesario el usario unico para identificar";
            }

            if (obj.Contrasena == "")
            {
                Mensaje += "Es necesario la clave del usuario";
            }

            //Si no se han cumplido las reglas de negocio, no debería llamar al método registrar
            if (Mensaje != "")
            {
                return false;
            }
            else
            {
                return objcd_usuario.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Usuarios obj, out string Mensaje)
        {
            return objcd_usuario.Eliminar(obj, out Mensaje);
        }
    }
}

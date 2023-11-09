using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Provedor
    {
        private CD_Provedor objcd_Provedor = new CD_Provedor();


        public List<Provedores> Listar()
        {
            return objcd_Provedor.Listar();
        }

        public int Registrar(Provedores obj, out string Mensaje)
        {
            Mensaje = "";

            if (obj.Provedor == "")
            {
                Mensaje += "Es necesario el nombre del proveedor\n";
            }

            if (obj.Telefono == "")
            {
                Mensaje += "Es necesario el telefono del proveedor\n";
            }

            if (obj.Correo == "")
            {
                Mensaje += "Es necesario el correo del proveedor\n";
            }

            //Si no se han cumplido las reglas de negocio, no debería llamar al método registrar
            if (Mensaje != "")
            {
                return 0;
            }
            else
            {
                return objcd_Provedor.Regitrar(obj, out Mensaje);
            }

        }

        public bool Editar(Provedores obj, out string Mensaje)
        {
            Mensaje = "";
            if (obj.Provedor == "")
            {
                Mensaje += "Es necesario el nombre del proveedor";
            }

            if (obj.Telefono == "")
            {
                Mensaje += "Es necesario el telefono del proveedor";
            }

            if (obj.Correo == "")
            {
                Mensaje += "Es necesario el correo del proveedor";
            }

            //Si no se han cumplido las reglas de negocio, no debería llamar al método registrar
            if (Mensaje != "")
            {
                return false;
            }
            else
            {
                return objcd_Provedor.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Provedores obj, out string Mensaje)
        {
            return objcd_Provedor.Eliminar(obj, out Mensaje);
        }
    }
}

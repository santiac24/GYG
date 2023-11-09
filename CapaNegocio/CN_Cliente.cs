using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Cliente
    {
        private CD_Cliente objcd_cliente = new CD_Cliente();


        public List<Clientes> Listar()
        {
            return objcd_cliente.Listar();
        }

        public int Registrar(Clientes obj, out string Mensaje)
        {
            Mensaje = "";

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre del cliente.";
            }

            if (obj.Cedula == "")
            {
                Mensaje += "Es necesario el número de celula del cliente para identificar.";
            }

            if (obj.Celular == "")
            {
                Mensaje += "Es necesario el celular del cliente.";
            }

            if (obj.Direccion == "")
            {
                Mensaje += "Es necesario poner la dirección del cliente.";
            }

            if (obj.o_Sexo.Id_sexo == 0)
            {
                Mensaje += "Es necesario poner el sexo del cliente.";
            }

            //Si no se han cumplido las reglas de negocio, no debería llamar al método registrar
            if (Mensaje != "")
            {
                return 0;
            }
            else
            {
                return objcd_cliente.Regitrar(obj, out Mensaje);
            }

        }

        public bool Editar(Clientes obj, out string Mensaje)
        {
            Mensaje = "";
            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre del cliente";
            }

            if (obj.Cedula == "")
            {
                Mensaje += "Es necesario el número de celula del cliente para identificar.";
            }

            if (obj.Celular == "")
            {
                Mensaje += "Es necesario el celular del cliente.";
            }

            if (obj.Direccion == "")
            {
                Mensaje += "Es necesario poner la dirección del cliente.";
            }

            if (obj.o_Sexo.Id_sexo == 0)
            {
                Mensaje += "Es necesario poner el sexo del cliente.";
            }

            //Si no se han cumplido las reglas de negocio, no debería llamar al método registrar
            if (Mensaje != "")
            {
                return false;
            }
            else
            {
                return objcd_cliente.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Clientes obj, out string Mensaje)
        {
            return objcd_cliente.Eliminar(obj, out Mensaje);
        }
    }
}

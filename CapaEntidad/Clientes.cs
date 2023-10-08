using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Clientes
    {
        public int Id_cliente { get; set; }
        public string Nombre { get; set; }
        public int Cedula { get; set; }
        public string Direccion { get; set; }
        public string Fecha_nacimiento { get; set; }
        public Sexos Sexo_id { get; set; }
    }
}

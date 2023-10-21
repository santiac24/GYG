using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Permisos
    {
        public int Id_permiso { get; set; }
        public string NombreMenu { get; set; }

        public string FechaRegistro { get; set; }

        public Roles oRol { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuarios
    {
        public int Id_usuario {  get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public int Rol_id { get; set; }
    }
}


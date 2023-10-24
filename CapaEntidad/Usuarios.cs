

namespace CapaEntidad
{
    public class Usuarios
    {
        public int Id_usuario { get; set; } = 0;

        public string Nombre { get; set; } = "";
        public string Usuario { get; set; } = "";
        public string Contrasena { get; set; } = "";
        public Roles o_Rol { get; set; };
    }
}


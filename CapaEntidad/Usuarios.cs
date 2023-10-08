

namespace CapaEntidad
{
    public class Usuarios
    {
        public int Id_usuario {  get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public Rol Rol_id { get; set; }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;


namespace CapaDatos
{
    public class CD_Usuario
    {
        public List<Usuarios> Listar()
        {
            List<Usuarios> lista = new List<Usuarios>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "SELECT u.Id_usuario, u.Nombre, u.Usuario, u.Contrasena, u.Rol_id, r.Id_rol, r.Rol FROM usuarios u INNER JOIN roles r ON u.Rol_id=r.Id_rol;";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var usuario = new Usuarios
                            {
                                Id_usuario = Convert.ToInt32(dr["Id_usuario"]),
                                Nombre = dr["Nombre"].ToString(),
                                Usuario = dr["Usuario"].ToString(),
                                Contrasena = dr["Contrasena"].ToString(),
                                o_Rol = new Roles()
                                {
                                    Id_rol = Convert.ToInt32(dr["Id_rol"]),
                                    rol = dr["Rol"].ToString()
                                }
                            };
                            lista.Add(usuario);
                        }

                    }
                }

                catch (Exception ex)
                {
                    lista = new List<Usuarios>();
                }
            }
        
            return lista;
        }
}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    internal class CD_PERMISO
    {
        public List<Permiso> Listar(int idusuario)
        {
            List<Permiso> lista = new List<Permiso>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.Rol_id,p.NombreMenu from PERMISOS p");
                    query.AppendLine("inner join ROLES r on r.Rol_id = p.Rol_id");
                    query.AppendLine("inner join USUARIOS u on u.Rol_id = r.Rol_id");
                    query.AppendLine("where u.Id_usuario = @idusuario");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@idusuario", idusuario);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Permiso()
                            {
                                oRol = new Rol() { Rol_id = Convert.ToInt32(dr[Rol_id]) }
                                NombreMenu = dr["NombreMenu"].ToString(),

                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Permiso>();
                }

            }

            return lista;
        }
    }
}

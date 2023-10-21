using System.Data;
using System.Data.SqlClient;
using System.Text;
using CapaEntidad;


namespace CapaDatos
{
    public class CD_Rol
    {
        public List<Roles> Listar()
        {
            List<Roles> lista = new List<Roles>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT Id_rol,Rol FROM ROLES");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Roles()
                            {
                                Id_rol = Convert.ToInt32(dr["Id_rol"]),
                                rol = dr["Rol"].ToString()

                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    lista = new List<Roles>();
                }

            }

            return lista;
        }
    }
}

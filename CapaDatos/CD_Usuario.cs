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
                    string query = "select Id_usuario, NombreUsuario, Contrasena, Rol_id from usuarios";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuarios()
                            {
                                Id_usuario = Convert.ToInt32(dr['Id_usuario']);
                            NombreUsuario = dr['NombreUsuario'].ToString();
                            Contrasena = dr['Contrasena'].ToString();
                            Rol_id = Convert.ToInt32(dr['Rol_id']);
                        });
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
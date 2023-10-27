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


        public int Regitrar(Usuarios obj, out string Mensaje)
        {
            int idusuariogenerado = 0;
            Mensaje = "";

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("P_REGISTRARUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("Usuario", obj.Usuario);
                    cmd.Parameters.AddWithValue("Contrasena", obj.Contrasena);
                    cmd.Parameters.AddWithValue("IdRol", obj.o_Rol.Id_rol);
                    cmd.Parameters.Add("IdUsuarioResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;


                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    idusuariogenerado = Convert.ToInt32(cmd.Parameters["IdUsuarioResultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }

                }
            catch (Exception ex)
            {
                idusuariogenerado = 0;
                Mensaje = ex.Message;
            }

            return idusuariogenerado;
        }

        public bool Editar(Usuarios obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = "";

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("P_EDITARUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("Id_Usuario", obj.Id_usuario);
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("Usuario", obj.Usuario);
                    cmd.Parameters.AddWithValue("Contrasena", obj.Contrasena);
                    cmd.Parameters.AddWithValue("IdRol", obj.o_Rol.Id_rol);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;


                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                Respuesta = false;
                Mensaje = ex.Message;
            }

            return Respuesta;
        }

        public bool Eliminar(Usuarios obj, out string Mensaje)
        {
            bool exito = false;
            Mensaje = "";

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("P_ELIMINARUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("Id_Usuario", obj.Id_usuario);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;


                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    exito = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                exito = false;
                Mensaje = ex.Message;
            }

            return exito;
        }
    }
}
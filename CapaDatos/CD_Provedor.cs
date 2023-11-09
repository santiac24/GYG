using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Provedor
    {
        public List<Provedores> Listar()
        {
            List<Provedores> lista = new List<Provedores>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select Id_provedor, Provedor, Telefono, Correo from PROVEDORES";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var Provedor = new Provedores
                            {
                                Id_provedor = Convert.ToInt32(dr["Id_Provedor"]),
                                Provedor = dr["Provedor"].ToString(),
                                Telefono = dr["Telefono"].ToString(),
                                Correo = dr["Correo"].ToString(),
                            };
                            lista.Add(Provedor);
                        }

                    }
                }

                catch (Exception ex)
                {
                    lista = new List<Provedores>();
                }
            }

            return lista;
        }


        public int Regitrar(Provedores obj, out string Mensaje)
        {
            int idProvedorgenerado = 0;
            Mensaje = "";

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarProvedor", oconexion);
                    cmd.Parameters.AddWithValue("Provedor", obj.Provedor);
                    cmd.Parameters.AddWithValue("Telefono", obj.Telefono);
                    cmd.Parameters.AddWithValue("Correo", obj.Correo);

                    SqlParameter resultadoParam = new SqlParameter("@Resultado", SqlDbType.Int);
                    resultadoParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(resultadoParam);

                    SqlParameter mensajeParam = new SqlParameter("@Mensaje", SqlDbType.VarChar, 500);
                    mensajeParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(mensajeParam);

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    idProvedorgenerado = Convert.ToInt32(resultadoParam.Value);
                    Mensaje = mensajeParam.Value.ToString();
                }

            }
            catch (Exception ex)
            {
                idProvedorgenerado = 0;
                Mensaje = ex.Message;
            }

            return idProvedorgenerado;
        }

        public bool Editar(Provedores obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = "";

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_ModificarProvedor", oconexion);
                    cmd.Parameters.AddWithValue("Id_Provedor", obj.Id_provedor);
                    cmd.Parameters.AddWithValue("Provedor", obj.Provedor);
                    cmd.Parameters.AddWithValue("Telefono", obj.Telefono);
                    cmd.Parameters.AddWithValue("Correo", obj.Correo);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;


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

        public bool Eliminar(Provedores obj, out string Mensaje)
        {
            bool exito = false;
            Mensaje = "";

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_EliminarProvedor", oconexion);
                    cmd.Parameters.AddWithValue("Id_Provedor", obj.Id_provedor);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;


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

using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Negocio
    {

        public Negocio ObtenerDatos()
        {
            Negocio obj = new Negocio();

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();

                    string query = "SELECT IdNegocio, Nombre, NIT, Direccion FROM NEGOCIO WHERE IdNegocio = 1";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    using(SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            obj = new Negocio()
                            {
                                IdNegocio = Convert.ToInt32(dr["IdNegocio"]),
                                Nombre = dr["Nombre"].ToString(),
                                NIT = dr["NIT"].ToString(),
                                Direccion = dr["Direccion"].ToString(),
                            };
                        }
                    }

                }
            }
            catch
            {
                obj = new Negocio();
            }

            return obj;

        }

        public bool GuardarDatos(Negocio objeto, out string mensaje )
        {
            mensaje = string.Empty;
            bool respuesta = true;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE NEGOCIO SET Nombre = @Nombre,");
                    query.AppendLine("NIT = @NIT,");
                    query.AppendLine("Direccion = @Direccion");
                    query.AppendLine("WHERE IdNegocio = 1;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
                    cmd.Parameters.AddWithValue("@NIT", objeto.NIT);
                    cmd.Parameters.AddWithValue("@Direccion", objeto.Direccion);
                    cmd.CommandType = CommandType.Text;

                    if(cmd.ExecuteNonQuery() < 1 )
                    {
                        mensaje = "No se pudo guardar los datos";
                        respuesta = false;
                    }


                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                mensaje = ex.Message;
            }

            return respuesta;
        }


        public byte[] ObtenerLogo(out bool obtenido)
        {
            obtenido = true;
            byte[] LogoBytes = new byte[0];

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    string query = "SELECT Logo FROM NEGOCIO WHERE IdNegocio = 1";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                     cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            //Conversión del formato de bytes de DB a código
                            LogoBytes = (byte[])dr["Logo"];
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                obtenido = false;
                LogoBytes = new byte[0];
            }

            return LogoBytes;

        }


        public bool ActualizarLogo(byte[] imagen, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE NEGOCIO SET Logo = @Imagen");
                    query.AppendLine("WHERE IdNegocio = 1;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@Imagen", imagen);
                    cmd.CommandType = CommandType.Text;

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        mensaje = "No se pudo actualizar el logo";
                        respuesta = false;
                    }


                }
            }
            catch (Exception ex)
            {
                respuesta = false;
                mensaje = ex.Message;
            }

            return respuesta;

        }
    }
}

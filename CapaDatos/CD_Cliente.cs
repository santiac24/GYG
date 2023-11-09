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
    public class CD_Cliente
    {
        public List<Clientes> Listar()
        {
            List<Clientes> lista = new List<Clientes>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT Id_cliente, Nombre, Cedula, Celular, Direccion, Fecha_nacimiento, Sexo_id from Clientes");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var cliente = new Clientes
                            {

                                Id_cliente = Convert.ToInt32(dr["Id_cliente"]),
                                Nombre = dr["Nombre"].ToString(),
                                Cedula = dr["Cedula"].ToString(),
                                Celular = dr["Celular"].ToString(),
                                Direccion = dr["Direccion"].ToString(),
                                Fecha_nacimiento = dr["Fecha_nacimiento"].ToString(),
                                o_Sexo = new Sexos()
                                {
                                    Id_sexo = Convert.ToInt32(dr["Id_sexo"]),
                                    Sexo = dr["Sexo"].ToString()
                                }
                            };
                            lista.Add(cliente);
                        }

                    }
                }

                catch (Exception ex)
                {
                    lista = new List<Clientes>();
                }
            }

            return lista;
        }


        public int Regitrar(Clientes obj, out string Mensaje)
        {
            int idClientegenerado = 0;
            Mensaje = String.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_RegistrarCliente", oconexion);
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("Cedula", obj.Cedula);
                    cmd.Parameters.AddWithValue("Celular", obj.Celular);
                    cmd.Parameters.AddWithValue("Direccion", obj.Direccion);
                    cmd.Parameters.AddWithValue("Fecha_nacimiento", obj.Fecha_nacimiento);
                    cmd.Parameters.AddWithValue("Sexo_id", obj.o_Sexo.Id_sexo);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;


                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    idClientegenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                idClientegenerado = 0;
                Mensaje = ex.Message;
            }

            return idClientegenerado;
        }

        public bool Editar(Clientes obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = String.Empty;

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("sp_ModificarCliente", oconexion);
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("Cedula", obj.Cedula);
                    cmd.Parameters.AddWithValue("Celular", obj.Celular);
                    cmd.Parameters.AddWithValue("Direccion", obj.Direccion);
                    cmd.Parameters.AddWithValue("Fecha_nacimiento", obj.Fecha_nacimiento);
                    cmd.Parameters.AddWithValue("Sexo_id", obj.o_Sexo.Id_sexo);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
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

        public bool Eliminar(Clientes obj, out string Mensaje)
        {
            bool exito = false;
            Mensaje = String.Empty;
            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("delete from Clientes where Id_cliente = @id", oconexion);
                    cmd.Parameters.AddWithValue("@id", obj.Id_cliente);
                    cmd.CommandType=CommandType.Text;
                    oconexion.Open();
                    exito = cmd.ExecuteNonQuery() > 0 ? true : false;
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

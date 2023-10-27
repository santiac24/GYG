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
    public class CD_Subcategoria
    {
        public List<SubCategorias> Listar()
        {
            List<SubCategorias> lista = new List<SubCategorias>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select Id_subcategoria, subcategoria, Categoria_id, c.Categoria from SUBCATEGORIAS sc inner join CATEGORIAS c on c.Id_categoria = sc.Categoria_id ";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var SubCategorias = new SubCategorias
                            {
                                Id_subcategoria = Convert.ToInt32(dr["Id_subcategoria"]),
                                subcategoria = dr["subcategoria"].ToString(),
                                Categoria_id = new Categorias()
                                {
                                    Id_categoria = Convert.ToInt32(dr["Categoria_id"]),
                                    Categoria = dr["Categoria"].ToString()
                                }
                            };
                            lista.Add(SubCategorias);
                        }

                    }
                }

                catch (Exception ex)
                {
                    lista = new List<SubCategorias>();
                }
            }

            return lista;
        }


        public int Regitrar(SubCategorias obj, out string Mensaje)
        {
            int Resultado = 0;
            Mensaje = "";

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_Registrarsubcategoria", oconexion);
                    cmd.Parameters.AddWithValue("Subcategoria", obj.subcategoria);
                    cmd.Parameters.AddWithValue("IdCategoria", obj.Categoria_id.Id_categoria);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    Resultado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                Resultado = 0;
                Mensaje = ex.Message;
            }

            return Resultado;
        }

        public bool Editar(SubCategorias obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = "";

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_Editarsubcategoria", oconexion);
                    cmd.Parameters.AddWithValue("Idsubcategoria", obj.Id_subcategoria);
                    cmd.Parameters.AddWithValue("Subcategoria", obj.subcategoria);
                    cmd.Parameters.AddWithValue("IdCategoria", obj.Categoria_id.Id_categoria);
                    
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

        public bool Eliminar(SubCategorias obj, out string Mensaje)
        {
            bool exito = false;
            Mensaje = "";

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_Eliminarsubcategoria", oconexion);
                    cmd.Parameters.AddWithValue("IdSubcategoria", obj.Id_subcategoria);
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

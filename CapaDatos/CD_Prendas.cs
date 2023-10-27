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
    public class CD_Prendas
    {

        public List<Prendas> Listar()
        {
            List<Prendas> lista = new List<Prendas>();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select Id_prenda, prenda, Cantidad_dispo, Precio_compra, Precio_venta, Subcategoria_id," +
                        " sc.subcategoria, Talla_id, t.Talla, Color_id, c.Color from PRENDAS p" +
                        "inner join SUBCATEGORIAS sc on sc.Id_subcategoria = p.Subcategoria_id" +
                        "inner join COLORES c on c.Id_color = p.Color_id" +
                        "inner join tallas t on t.Id_talla = p.Talla_id ";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var Prendas = new Prendas
                            {
                                Id_prenda = Convert.ToInt32(dr["Id_Prenda"]),
                                Prenda = dr["prenda"].ToString(),
                                Cantidad_dispo = Convert.ToInt32(dr["Cantidad_dispo"]),
                                Precio_compra = Convert.ToDecimal(dr["Precio_compra"].ToString()),
                                Precio_venta = Convert.ToDecimal(dr["Precio_venta"].ToString()),
                                Subcategoria_id = new SubCategorias()
                                {
                                    Id_subcategoria = Convert.ToInt32(dr["Subcategoria_id"]),
                                    subcategoria = dr["subcategoria"].ToString()
                                },
                                Talla_id = new Tallas()
                                {
                                    Id_talla = Convert.ToInt32(dr["Talla_id"]),
                                    Talla = dr["Talla"].ToString()
                                },
                                Color_id = new Colores()
                                {
                                    Id_color = Convert.ToInt32(dr["Color_id"]),
                                    Color = dr["Color"].ToString()
                                }
                            };
                            lista.Add(Prendas);
                        }

                    }
                }

                catch (Exception ex)
                {
                    lista = new List<Prendas>();
                }
            }

            return lista;
        }


        public int Regitrar(Prendas obj, out string Mensaje)
        {
            int idPrendasgenerado = 0;
            Mensaje = "";

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_Registrarprenda", oconexion);
                    cmd.Parameters.AddWithValue("Prenda", obj.Prenda);
                    cmd.Parameters.AddWithValue("Subcategoria_id", obj.Subcategoria_id.Id_subcategoria);
                    cmd.Parameters.AddWithValue("Talla_id", obj.Talla_id.Id_talla);
                    cmd.Parameters.AddWithValue("Color_id", obj.Color_id.Id_color);
                    cmd.Parameters.AddWithValue("Cantidad_dispo", obj.Cantidad_dispo);
                    cmd.Parameters.AddWithValue("Precio_compra", obj.Precio_compra);
                    cmd.Parameters.AddWithValue("Precio_venta", obj.Precio_venta);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    idPrendasgenerado = Convert.ToInt32(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                }

            }
            catch (Exception ex)
            {
                idPrendasgenerado = 0;
                Mensaje = ex.Message;
            }

            return idPrendasgenerado;
        }

        public bool Editar(Prendas obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = "";

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_Modificarprenda", oconexion);
                    cmd.Parameters.AddWithValue("Id_prenda", obj.Id_prenda);
                    cmd.Parameters.AddWithValue("Prenda", obj.Prenda);
                    cmd.Parameters.AddWithValue("Subcategoria_id", obj.Subcategoria_id.Id_subcategoria);
                    cmd.Parameters.AddWithValue("Talla_id", obj.Talla_id.Id_talla);
                    cmd.Parameters.AddWithValue("Color_id", obj.Color_id.Id_color);
                    cmd.Parameters.AddWithValue("Cantidad_dispo", obj.Cantidad_dispo);
                    cmd.Parameters.AddWithValue("Precio_compra", obj.Precio_compra);
                    cmd.Parameters.AddWithValue("Precio_venta", obj.Precio_venta);
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

        public bool Eliminar(Prendas obj, out string Mensaje)
        {
            bool exito = false;
            Mensaje = "";

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    SqlCommand cmd = new SqlCommand("SP_Eliminarprenda", oconexion);
                    cmd.Parameters.AddWithValue("Id_Prenda", obj.Id_prenda);
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

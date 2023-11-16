using CapaEntidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CapaDatos
{
    public class CD_Compra
    {
        public int ObtenerCorrelativo() { 
            int idcorrelativo = 0;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select count(*) + 1 from compras";
                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();
                    idcorrelativo = Convert.ToInt32(cmd.ExecuteScalar());
                }

                catch (Exception ex)
                {
                    idcorrelativo = 0;
                }
            }

            return idcorrelativo;
        }
        public bool Registrar(Compras obj, DataTable DetalleCompra, out string Mensaje)
        {
            bool Resultado = false;
            Mensaje = string.Empty;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_RegistrarCompra", oconexion);
                    cmd.Parameters.AddWithValue("Valor", obj.Valor);
                    cmd.Parameters.AddWithValue("Id_usuario", obj.o_usuario.Id_usuario);
                    cmd.Parameters.AddWithValue("Provedor_id", obj.o_Provedor.Id_provedor);
                    cmd.Parameters.AddWithValue("DetalleCompra", DetalleCompra);
                    cmd.Parameters.AddWithValue("NumeroDocumento", obj.NumeroDocumento);
                    cmd.Parameters.AddWithValue("TipoDocumento", obj.TipoDocumento);
                    cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;


                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    Resultado = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }

                catch (Exception ex)
                {
                    Resultado = false;
                    Mensaje = ex.Message;
                }
            }

            return Resultado;
        }

        public Compras obtenercompra(string numero)
        {
            Compras obj = new Compras();
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    string query = "select c.Id_compra, u.Nombre, pr.Id_provedor, pr.Provedor, " +
                        "c.TipoDocumento, c.NumeroDocumento, c.Valor, CONVERT(char(10),c.Fecha,103)[Fecha] " +
                        "from compras c inner join USUARIOS u on u.Id_usuario = c.Usuario_id " +
                        "inner join PROVEDORES pr on pr.Id_provedor = c.Provedor_id " +
                        "where c.NumeroDocumento = @numero";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            obj = new Compras()
                            {
                                Id_compra = Convert.ToInt32(dr["Id_compra"]),
                                o_usuario = new Usuarios() { Nombre = dr["Nombre"].ToString(),Id_usuario= Convert.ToInt32(dr["Id_provedor"])},
                                o_Provedor = new Provedores() { Provedor = dr["Provedor"].ToString() },
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                Valor = Convert.ToDecimal(dr["Valor"].ToString()),
                                Fecha = dr["Fecha"].ToString(),
                            };
                        }

                    }
                }

                catch (Exception ex)
                {
                    obj = new Compras();
                }
                return obj;
            }
        }

        public List<Detalles_compras> obtenerDetallecompra(int idcompra)
        {
            List<Detalles_compras> olista = new List<Detalles_compras>();

            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    oconexion.Open();

                    string query = "select p.prenda, dc.Precio_compra_unidad, dc.Cantidad, dc.montoTotal " +
                        "from DETALLE_COMPRAS dc " +
                        "inner join prendas p on p.Id_prenda = dc.Prenda_id " +
                        "where dc.Compra_id = @idcompra ";

                    SqlCommand cmd = new SqlCommand(query, oconexion);
                    cmd.Parameters.AddWithValue("@idcompra", idcompra);
                    cmd.CommandType = CommandType.Text;


                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var detallecompra = new Detalles_compras
                            {
                                Prenda_id = new Prendas() { Prenda = dr["prenda"].ToString() },
                                Precio_compra_unidad = Convert.ToDecimal(dr["Precio_compra_unidad"].ToString()),
                                Cantidad = Convert.ToInt32(dr["Cantidad"].ToString()),
                                Subtotal = Convert.ToDecimal(dr["montoTotal"].ToString()),
                            };
                            olista.Add(detallecompra);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                olista = new List<Detalles_compras>();
            }
            return olista;
        }
    }
}



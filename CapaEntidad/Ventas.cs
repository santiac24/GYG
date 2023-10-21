namespace CapaEntidad
{
    public class Ventas
    {
        public int Id_venta { get; set; }
        public string Fecha { get; set; }
        public float Valor { get; set; }
        public Clientes Cliente_id { get; set; }
        public Usuarios Usuario_id { get; set; }
        public Formas_pago Forma_pago_id { get; set; }
        public List<Detalles_ventas> Odetalle_venta { get; set; }

    }
}

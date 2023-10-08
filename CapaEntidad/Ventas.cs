namespace CapaEntidad
{
    public class Ventas
    {
        public int Id_venta { get; set; }
        public string Fecha { get; set; }
        public float Valor { get; set; }
        public Clientes Cliente_id { get; set; }
        public Usuarios Usuario_id { get; set; }
        public Forma_pago Forma_pago_id { get; set; }
        public List<Detalle_ventas> Odetalle_venta { get; set; }

    }
}

namespace CapaEntidad
{
    public class Ventas
    {
        public int Id_venta { get; set; }
        public string Fecha { get; set; }
        public float Valor { get; set; }
        public int Cliente_id { get; set; }
        public int Usuario_id { get; set; }
        public int Forma_pago_id { get; set; }

    }
}

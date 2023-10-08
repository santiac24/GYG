using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Detalle_ventas
    {
        public int Id_detalle_venta { get; set; }
        public Ventas Venta_id { get; set; }
        public Prendas Prenda_id { get; set; }
        public int Cantidad { get; set; }
        public float Precio_venta_unidad { get; set; }
        public float Subtotal { get; set; }
    }
}

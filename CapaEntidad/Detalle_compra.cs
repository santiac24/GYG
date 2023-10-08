using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    internal class Detalle_compra
    {
        public int Id_detalle_compra { get; set; }
        public int Compra_id { get; set; }
        public int Prenda_id { get; set; }
        public int Cantidad { get; set; }
        public int Provedor_id { get; set; }
        public float Precio_venta_unidad { get; set; }
        public float Subtotal { get; set; }

    }
}

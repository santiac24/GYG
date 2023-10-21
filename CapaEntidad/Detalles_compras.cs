using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Detalles_compras
    {
        public int Id_detalle_compra { get; set; }
        public Compras Compra_id { get; set; }
        public Prendas Prenda_id { get; set; }
        public int Cantidad { get; set; }
        public Provedores Provedor_id { get; set; }
        public float Precio_venta_unidad { get; set; }
        public float Subtotal { get; set; }

    }
}

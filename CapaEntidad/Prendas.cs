using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    internal class Prendas
    {
        public int Id_prenda { get; set; }
        public int Cantidad_dispo { get; set; }

        public float Precio_compra { get; set; }
        public float Precio_venta { get; set; }
        public int Subcategoria_id { get; set; }
        public int Talla_id { get; set; }
        public int Color_id { get; set; }
    }
}

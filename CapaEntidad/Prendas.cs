using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Prendas
    {
        public int Id_prenda { get; set; }
        public int Cantidad_dispo { get; set; }

        public float Precio_compra { get; set; }
        public float Precio_venta { get; set; }
        public SubCategoria Subcategoria_id { get; set; }
        public Tallas Talla_id { get; set; }
        public Colores Color_id { get; set; }
    }
}

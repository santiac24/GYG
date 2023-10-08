using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compras
    {
        public int Id_compra { get; set; }
        public string Fecha { get; set; }
        public float Valor { get; set;}

        public List<Detalle_compra> Odetalle_compra { get; set; }
    }
}

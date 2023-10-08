using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Plan_separe
    {
        public int Id_separe { get; set; }
        public Clientes Cliente_id { get; set; }
        public Ventas Venta_id { get; set; }
        public float valor_restante { get; set; }
    }
}

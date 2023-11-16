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
        public string NumeroDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public decimal Valor { get; set;}
        public Provedores o_Provedor { get; set; }
        public Usuarios o_usuario { get; set; }
        public List<Detalles_compras> Odetalle_compra { get; set; }
    }
}

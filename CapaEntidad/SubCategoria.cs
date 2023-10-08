using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class SubCategoria
    {
        public int Id_subcategoria { get; set; }
        public string subcategoria { get; set; }
        public Categorias Categoria_id { get; set; }
    }
}

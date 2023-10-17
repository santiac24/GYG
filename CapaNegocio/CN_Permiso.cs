using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaPermiso
{
    public class CN_Permiso
    {
        private CD_PERMISO objcd_permiso = new CD_PERMISO();


        public List<Permiso> Listar(int Id_usuario)
        {
            return objcd_permiso.Listar(Id_usuario);
        }
    }
}


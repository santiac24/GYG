using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Sexo
    {
        private CD_Sexo objcd_Sexos = new CD_Sexo();


        public List<Sexos> Listar()
        {
            return objcd_Sexos.Listar();
        }
    }
}

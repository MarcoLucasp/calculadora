using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyectocontrolar.Models
{
    public class tiposCuentas
    {
        public int tiposCuentaID { get; set; }
        public string nombreTipoCuentas { get; set; }
        public int usuarioid { get; set; }
        public int  ordenTipoCuentas { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Servicio_Lista_Numero.Models
{
    public class Data
    {
        public string Channel { get; set; }
        public ICollection<BusiinesHours> Days_working { get; set; }
        public Config Configuration { get; set; }

    }
}

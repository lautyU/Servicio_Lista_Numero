using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Servicio_Lista_Numero.Models
{
    public class Availability
    {
        public string TypeLocal { get; set; }
        public ICollection<BusiinesHours> working_time { get; set; }
        public List<Hours> Out_of_services { get; set; }

    }
}

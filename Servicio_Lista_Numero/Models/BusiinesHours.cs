using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Servicio_Lista_Numero.Models
{
    public class BusiinesHours
    {
        public ICollection<Hours> Includes { get; set; }

        public Boolean Holidays { get; set; }


        public Message Message { get; set; }
    }
}

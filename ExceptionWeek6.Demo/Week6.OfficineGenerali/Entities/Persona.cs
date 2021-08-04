using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6.OfficineGenerali.Entities
{
    public abstract class Persona
    {
        public string CodiceFiscale { get; set; }
        public string Indirizzo { get; set; }
        public string Telefono { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6.OfficineGenerali.Entities
{
    public class Riparazione
    {
        public string Codice { get; set; }
        public DateTime Accettazione { get; set; }
        public DateTime Riconsegna { get; set; }
        public Veicolo Veicolo { get; set; }
    }
}

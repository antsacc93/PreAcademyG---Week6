using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6.AppComune.Entities
{
    public class Contravvenzione
    {
        public int Numero { get; set; }
        public Vigile Vigile { get; set; }
        public Veicolo Veicolo { get; set; }
        public string Luogo { get; set; }
    }
}

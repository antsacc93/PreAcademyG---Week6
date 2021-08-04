using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6.AppComune.Entities
{
    public abstract class Veicolo
    {
        public string Targa { get; set; }
        public IList<Contravvenzione> Contravvenzioni { get; set; } = new List<Contravvenzione>();
    }
}

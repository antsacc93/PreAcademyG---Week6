using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6.OfficineGenerali.Entities
{
    public class Officina
    {
        public string Nome { get; set; }
        public string Indirizzo { get; set; }
        public IList<Dipendente> Dipendenti { get; set; } = new List<Dipendente>();
        public int NumeroDipendenti { get { return Dipendenti.Count; } }
        public Direttore Direttore { get; set; }
        public IList<Riparazione> Riparazioni { get; set; } = new List<Riparazione>();
    }
}

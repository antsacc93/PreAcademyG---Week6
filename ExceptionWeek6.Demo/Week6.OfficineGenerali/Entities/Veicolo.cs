using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6.OfficineGenerali.Entities
{
    public class Veicolo
    {
        public string Targa { get; set; }
        public string Modello { get; set; }
        public string Tipo { get; set; }
        public int AnnoImmatricolazione {get; set; }
        public Proprietario Proprietario { get; set; }
    }
}

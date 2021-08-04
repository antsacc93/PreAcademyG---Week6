using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6.OfficineGenerali.Entities
{
    public class Direttore : Persona
    {
        //public int Eta { get; set; }
        public DateTime DataNascita { get; set; }
        public int Eta { get { return DateTime.Today.Year - DataNascita.Year;  } }

    }
}

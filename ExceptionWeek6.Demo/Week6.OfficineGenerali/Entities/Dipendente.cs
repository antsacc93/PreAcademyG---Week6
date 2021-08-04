using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6.OfficineGenerali.Entities
{
    public class Dipendente : Persona
    {
        //public int AnniServizio { get; set; }
        public DateTime DataAssunzione { get; set; }

        public int AnniServizio { get { return DateTime.Today.Year - DataAssunzione.Year; } }

    }
}

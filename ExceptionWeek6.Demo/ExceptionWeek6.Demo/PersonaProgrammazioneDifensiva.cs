using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionWeek6.Demo
{
    public class PersonaProgrammazioneDifensiva
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public override bool Equals(object obj)
        {
            Persona p;
            if (obj.GetType() == this.GetType()) //se entrambi sono di tipo persona
            {
                p = (Persona)obj;
            }
            else
            {
                return false;
            }
                
            
            if (p == null)
            {
                return false;
            }
            else
            {
                if (Nome.Equals(p.Nome) && Cognome.Equals(p.Cognome))
                {
                    return true;
                }
                return false;
            }
        }
    }
}

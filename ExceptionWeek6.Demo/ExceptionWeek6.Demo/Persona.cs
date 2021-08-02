using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionWeek6.Demo
{
    public class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }

        public override bool Equals(object obj)
        {           
            try
            {
                Persona p = (Persona)obj;
                if (Nome.Equals(p.Nome) && Cognome.Equals(p.Cognome))
                {
                    return true;
                }
                return false;
            }
            
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"C'è stato un errore nel codice {ex.Message}");
                return false;
            }
            catch(InvalidCastException ex)
            {
                Console.WriteLine($"C'è stato un errore di conversione {ex.Message}");
                return false;
            }
            catch (Exception exG)
            {
                Console.WriteLine($"Si è verificato un errore generico");
                return false;
            }

        }
    }
}

using System;

namespace ExceptionWeek6.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona() { Nome = "Mario", Cognome = "Rossi" };
            //Persona p2 = new Persona() { Nome = "Mario", Cognome = "Rossi" };
            Persona p2 = null;
            //Prima modalità di gestione dell'errore (con blocco try-catch)
            if (p.Equals(p2))
            {
                Console.WriteLine("Persone uguali");
            }
            else
            {
                Console.WriteLine("Persone diverse");
            }
            Prodotto prodotto = new Prodotto() { Codice = "123abc", Prezzo = 12.3m };
            p.Equals(prodotto);

            PersonaProgrammazioneDifensiva ppd = new PersonaProgrammazioneDifensiva() 
            {
                Nome = "Mario", 
                Cognome = "Rossi" 
            };
            //Seconda modalità di gestione dell'errore (con programmazione difensiva)
            if (p2 != null)
            {
                if (ppd.Equals(p2))
                {
                    Console.WriteLine("Persone uguali");
                }
                else
                {
                    Console.WriteLine("Persone diverse");
                }
            }
            ppd.Equals(prodotto);

            int.Parse(Console.ReadLine());
            int.TryParse(Console.ReadLine(), out int value);

            
        }
    }
}

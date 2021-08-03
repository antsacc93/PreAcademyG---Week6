using System;

namespace Week6.NumeriComplessi.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // a + ib
            // c + id
            Console.WriteLine("Inserisci parte reale del primo numero complesso");
            double.TryParse(Console.ReadLine(), out double a);
            Console.WriteLine("Inserisci parte immaginaria del primo numero complesso");
            double.TryParse(Console.ReadLine(), out double b);
            Console.WriteLine("Inserisci parte reale del secondo numero complesso");
            double.TryParse(Console.ReadLine(), out double c);
            Console.WriteLine("Inserisci parte immaginaria del secondo numero complesso");
            double.TryParse(Console.ReadLine(), out double d);

            NumeroComplesso primo = new NumeroComplesso { ParteReale = a, ParteImmaginaria = b };
            NumeroComplesso secondo = new NumeroComplesso { ParteReale = c, ParteImmaginaria = d };
            
            try
            {
                NumeroComplesso risultato = primo.Divisione(secondo);
                Console.WriteLine(risultato);
            }
            catch(NumeroComplessoException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine($"Dividendo: {ex.PrimoOperatore} - Divisore: {ex.SecondoOperatore}");
            }
            
        }
    }
}

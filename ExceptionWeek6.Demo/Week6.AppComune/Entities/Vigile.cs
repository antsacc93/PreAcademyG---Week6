using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6.AppComune.Entities
{
    public class Vigile
    {
        public string Matricola { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public IList<Contravvenzione> ContravvenzioniEffettuate { get; set; } = new List<Contravvenzione>();

        public void MultaVeicolo(Contravvenzione contravvenzione)
        {
            contravvenzione.Vigile = this;
            ContravvenzioniEffettuate.Add(contravvenzione);
        }

        public void MultaVeicolo(string luogo, Veicolo veicolo, int numero)
        {
            Contravvenzione nuovaContravvenzione = new Contravvenzione
            {
                Numero = numero,
                Luogo = luogo,
                Veicolo = veicolo,
                Vigile = this
            };
            ContravvenzioniEffettuate.Add(nuovaContravvenzione);
        }

    }
}

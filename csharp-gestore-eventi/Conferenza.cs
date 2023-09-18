using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class Conferenza : Evento
    {
        private string relatore;
        private double prezzo;
        public Conferenza(string Titolo, DateTime Data, int Capienza, int PostiPrenotati, string Relatore, double Prezzo) : base(Titolo, Data, Capienza, PostiPrenotati)
        {
            this.relatore = Relatore;
            this.prezzo = Prezzo;
        }

        //Getter
    }
}

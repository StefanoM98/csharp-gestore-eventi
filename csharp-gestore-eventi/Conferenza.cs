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
        public string GetRelatore()
        {
            return this.relatore;
        }

        public double GetPrezzo()
        {
            return this.prezzo;
        }

        //Setter

        public void SetRelatore(string relatore)
        {
            this.relatore = relatore;
        }    

        public void SetPrezzo(double prezzo)
        {
            this.prezzo = prezzo;
        }

        //Metodo

        public override string ToString()
        {
            string conferenza = base.ToString() + " - " + this.relatore + " - " + prezzo.ToString("0.00") + " euro";
            return conferenza;
        }
    }
}

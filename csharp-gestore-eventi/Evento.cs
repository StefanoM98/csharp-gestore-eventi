using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class Evento
    {
        private string Titolo;
        private DateTime Data;
        private int Capienza;
        private int PostiPrenotati;

        public Evento(string titolo, DateTime data, int capienza, int postiPrenotati = 0) 
        {
            this.Titolo = titolo;
            this.Data = data;
            this.Capienza = capienza;
            if (this.Capienza < 0)
            {
                throw new Exception("La capienza non puo essere un numero negativo");
            }
            this.PostiPrenotati = postiPrenotati;
        } 

        //GETTER

        public string GetTitolo()
        {
            return this.Titolo;
        }

        public DateTime GetDate()
        { 
            return this.Data;
        }   

        public int GetCapienza()
        {
            return this.Capienza;
        }

        public int GetPostiPrenotati()
        {
            return PostiPrenotati;
        }

        //SETTER

        public void SetTitolo(string titolo)
        {
            this.Titolo= titolo;
            
            if (titolo == "")
            {
                throw new ArgumentException("Devi inserire il titolo, non possiamo avviare un evento senza titolo");
            }
        }

        public void SetData(DateTime data)
        {
            this.Data= data;

            DateTime dataAttuale = DateTime.Now;
            
            if(data < dataAttuale)
            {
                throw new ArgumentException("La data non puo essere antecedente rispetto alla data odierna, ricorda di inserire una data futura.");
            }
        }

        //METODI
        public void PrenotaPostiEvento(int postiUtente)
        {
            if(PostiPrenotati > this.Capienza)
            {
                throw new ArgumentException("I posti sono gia tutti prenotati, riprova il prossimo evento");
            } 
            else if (this.Data < DateTime.Now)
            {
                throw new ArgumentException("L'evento è terminato mi dispiace");
            } 
            else
            {
                PostiPrenotati += postiUtente;
            }
        }

        public void DisdiciPosti(int postiDisdetti)
        {
            if (postiDisdetti < 0)
            {
                throw new ArgumentException("Il numero dei posti disdetti non può essere minore di 0!");
            }
            else if (postiDisdetti > this.PostiPrenotati)
            {
                throw new ArgumentException("Il numero dei posti che vuoi disdire è maggiore al numero dei posti prenotati!");
            }
            else
            {
                this.PostiPrenotati -= postiDisdetti;
            }
        }

        public override string ToString()
        {
            string infoEvento = Data.ToString("dd/MM/yyyy") + " - " + this.Titolo;
            return infoEvento;
        }
    }
}

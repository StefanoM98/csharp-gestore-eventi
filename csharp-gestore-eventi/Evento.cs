using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class Evento
    {
        private string titolo;
        private DateTime data;
        private int capienza;
        private int postiPrenotati;

        public Evento(string Titolo, DateTime Data, int Capienza, int PostiPrenotati = 0) 
        {
            this.titolo = Titolo;
            this.data = Data;
            this.capienza = Capienza;
            if (this.capienza < 0)
            {
                throw new Exception("La capienza non puo essere un numero negativo");
            }
            this.postiPrenotati = PostiPrenotati;
        } 

        //GETTER

        public string GetTitolo()
        {
            return this.titolo;
        }

        public DateTime GetDate()
        { 
            return this.data;
        }   

        public int GetCapienza()
        {
            return this.capienza;
        }

        public int GetPostiPrenotati()
        {
            return postiPrenotati;
        }

        //SETTER

        public void SetTitolo(string titolo)
        {
            this.titolo= titolo;
            
            if (titolo == "")
            {
                throw new ArgumentException("Devi inserire il titolo, non possiamo avviare un evento senza titolo");
            }
        }

        public void SetData(DateTime data)
        {
            this.data= data;

            DateTime dataAttuale = DateTime.Now;
            
            if(data < dataAttuale)
            {
                throw new ArgumentException("La data non puo essere antecedente rispetto alla data odierna, ricorda di inserire una data futura.");
            }
        }

        //METODI
        public void PrenotaPostiEvento(int postiUtente)
        {
            if(postiPrenotati > this.capienza)
            {
                throw new ArgumentException("I posti sono gia tutti prenotati, riprova il prossimo evento");
            } 
            else if (this.data < DateTime.Now)
            {
                throw new ArgumentException("L'evento è terminato mi dispiace");
            } 
            else
            {
                postiPrenotati += postiUtente;
            }
        }

        public void DisdiciPosti(int postiDisdetti)
        {
            if (postiDisdetti < 0)
            {
                throw new ArgumentException("Il numero dei posti disdetti non può essere minore di 0!");
            }
            else if (postiDisdetti > this.postiPrenotati)
            {
                throw new ArgumentException("Il numero dei posti che vuoi disdire è maggiore al numero dei posti prenotati!");
            }
            else
            {
                this.postiPrenotati -= postiDisdetti;
            }
        }

        public override string ToString()
        {
            string infoEvento = data.ToString("dd/MM/yyyy") + " - " + this.titolo;
            return infoEvento;
        }
    }
}

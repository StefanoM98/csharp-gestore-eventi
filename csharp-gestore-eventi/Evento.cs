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
        private static int PostiPrenotati = 0;

        public Evento(string titolo, DateTime data, int capienza) 
        {
            this.Titolo = titolo;
            this.Data = data;
            this.Capienza = capienza;
            if (this.Capienza < 0)
            {
                throw new Exception("La capienza non puo essere un numero negativo");
            }
            PostiPrenotati++;
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

        public void PrenotaPostiEvento()
        {
            Console.WriteLine("Quanti posti vuoi prenotare?");
        }
    }
}

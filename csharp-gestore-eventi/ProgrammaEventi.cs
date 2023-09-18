using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class ProgrammaEventi
    {
        private string titolo;
        private int numeriEventi;
        private List<Evento> eventi;

        public ProgrammaEventi(string Titolo, int NumeriEventi)
        {
            this.titolo = Titolo;
            this.numeriEventi = NumeriEventi;
            this.eventi = new List<Evento>();
        }

        //Getter
        public string GetTitolo()
        {
            return this.titolo;
        }

        public int GetNumeriEventi()
        {
            return this.numeriEventi;
        }

        public List<Evento> GetEventi() 
        {
            return this.eventi;
        }

        //Setter

        public void SetTitolo(string titolo)
        {
            this.titolo = titolo;
        }

        public void SetNumeriEventi(int numeriEventi)
        {
           this.numeriEventi = numeriEventi;
        }

        //Metodi

        public void AggiungiListaEventi(List<Evento> eventi)
        {
            foreach(Evento evento in eventi)
            {
                this.eventi.Add(evento);
            }
        }

        public void AggiungiEvento(Evento evento)
        {
            this.eventi.Add(evento);
        }

        public void EventiPerData(DateTime dataEvento)
        {
            List<Evento> listaEventiPerData = new List<Evento>();
            foreach(Evento evento in eventi)
            {
                if (dataEvento == evento.GetDate())
                {
                    listaEventiPerData.Add(evento);
                }
            }
            foreach(Evento evento in listaEventiPerData)
            {
                Console.WriteLine(dataEvento.ToString("dd/MM/yyyy") + " - " + this.titolo);
            }
        }

        public void StampaLista(List<Evento> listaEventi)
        {
            foreach (Evento evento in listaEventi)
            {
                Console.WriteLine(listaEventi);
            }
        }

        public void CancellaEventi()
        {
            eventi.Clear();
        }

        public override string ToString()
        {
            string programmaEventi = $"Titolo programma: {this.titolo}";

            foreach (Evento evento in eventi)
            {
                programmaEventi += evento.ToString();
            }
            return programmaEventi;
        }
    }
}

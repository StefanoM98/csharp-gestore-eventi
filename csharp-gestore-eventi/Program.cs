namespace csharp_gestore_eventi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Inserisci il nome del Programma degli eventi: ");
            string nomeProgramma = Console.ReadLine();
            if (nomeProgramma == "")
            {
                throw new Exception("Il nome del programma non può essere nullo");
            }
            Console.Write("Inserisci ora il numero di eventi che vuoi dichiarare: ");
            int numeriProgramma = int.Parse(Console.ReadLine());
            if (numeriProgramma < 0)
            {
                throw new Exception("Il numero dei programmi non può essere minore di 0");
            }
            ProgrammaEventi nuovoProgramma = new ProgrammaEventi(nomeProgramma, numeriProgramma);

            for (int i = 0; i < numeriProgramma; i++)
            {
                try
                {

                    Console.Write("Qual è il nome dell'evento: ");
                    string nome = Console.ReadLine();

                    Console.Write("Inserisci ora la data dell'evento (gg/MM/aaaa): ");
                    DateTime data = DateTime.Parse(Console.ReadLine());

                    Console.Write("Inserisci ora la capienza massima dell'evento: ");
                    int maxPosti = int.Parse(Console.ReadLine());

                    Console.Write("Quanti posti vuoi prenotare: ");
                    int posti = int.Parse(Console.ReadLine());





                    Evento evento = new Evento(nome, data, maxPosti, posti);

                    List<Evento> listaDiEventi = new List<Evento> { evento };

                    nuovoProgramma.AggiungiListaEventi(listaDiEventi);

                    Console.WriteLine($"Numero di posti disponibili: {maxPosti - evento.GetPostiPrenotati()}");
                    Console.WriteLine($"Numero di posti prenotati: {evento.GetPostiPrenotati()}");
                    bool eliminaPosti = false;

                    while (!eliminaPosti)
                    {
                        Console.WriteLine("Vuoi disdire i posti che hai prenotato?");
                        string risposta = Console.ReadLine();
                        if (risposta == "si")
                        {
                            Console.WriteLine("Indica adesso quanti posti vuoi disdire: ");

                            int postiDisdetti = int.Parse(Console.ReadLine());

                            evento.DisdiciPosti(postiDisdetti);

                            Console.WriteLine($"Posti disponibili: {maxPosti - evento.GetPostiPrenotati()}");

                            Console.WriteLine($"Posti prenotati: {evento.GetPostiPrenotati()}");
                        }
                        else if (risposta == "no")
                        {
                            Console.WriteLine("Hai scelto di non disdire i posti, verrai reinderizzato nella pagina seguente....");
                            eliminaPosti = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Errore: {ex.Message}");
                }
            }
            Console.WriteLine("------------------------");

            Console.WriteLine($"Numero di eventi programmati: {nuovoProgramma.GetNumeriEventi()}");
            Console.WriteLine($"{nuovoProgramma.ToString()}");

            Console.WriteLine("------------------------");

            Console.Write($"Per quale data vuoi cercare gli eventi che sono in programma: ");
            DateTime dataEvento = DateTime.Parse(Console.ReadLine());

            nuovoProgramma.EventiPerData(dataEvento);


            Console.WriteLine("Conferenze!!");

            Console.Write("Aggiungiamo ora una conferenza inserendo il nome: ");

            string conferenza = Console.ReadLine();

            Console.Write("Inserisci la data della conferenza(gg/mm/yyyy): ");

            DateTime dataConferenza = DateTime.Parse(Console.ReadLine());

            Console.Write("Inserisci i posti della tua conferenza: ");

            int postiConferenza = int.Parse(Console.ReadLine());
            int postiPrenotati = 0;

            Console.Write("Inserisci il nome del relatore: ");
            string nomeRelatore = Console.ReadLine();

            Console.Write("Inserisci il prezzo della conferenza: ");
            double costoConferenza = double.Parse(Console.ReadLine());

            Conferenza nuovaConferenza = new Conferenza(conferenza, dataConferenza, postiConferenza, postiPrenotati, nomeRelatore, costoConferenza);

            nuovoProgramma.AggiungiEvento(nuovaConferenza);

            Console.WriteLine("Ecco il programma eventi con anche le conferenze!");
            Console.WriteLine(nuovoProgramma.ToString());
        }
    }
}
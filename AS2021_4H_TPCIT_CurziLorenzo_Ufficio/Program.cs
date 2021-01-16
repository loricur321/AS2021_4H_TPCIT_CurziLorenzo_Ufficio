using System;
using AS2021_4H_TPCIT_CurziLorenzo_Ufficio.Models;

namespace AS2021_4H_TPCIT_CurziLorenzo_Ufficio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programma Ufficio di Lorenzo Curzi 4H, 15/01/2021");

            Ufficio pratiche = new Ufficio();

            pratiche.InserisciPratica("Mario", "Rossi", 'A', "Pratica di prova");

            Console.WriteLine(pratiche.RicercaPraticaCodice(1));

            pratiche.InserisciPratica("Mario", "Verdi", 'B', "Altra pratica");

            Console.WriteLine(pratiche.RicercaPraticaCodice(2));

            pratiche.InserisciPratica("Giuseppe", "Verdi", 'A', "Pratica");

            pratiche.InserisciPratica("Ludwig", "Van Beethoven", 'B', "Componimento");

            Console.WriteLine("\nRicerca pratiche di categoria A");
            Console.WriteLine(pratiche.RicercaPraticheTipo('A'));

            Console.WriteLine("\nRicerca pratiche di categoria B");
            Console.WriteLine(pratiche.RicercaPraticheTipo('B'));

            Console.WriteLine("\nRimozione dell'ultima pratica salvata");

            if (pratiche.EliminazionePratica(4))
                Console.WriteLine("Pratica rimossa con successo.");
            else
                Console.WriteLine("Rimozione pratica non riuscita.");

            Console.WriteLine("\nSalvataggio su file di tutte le pratiche in coda");
            if (pratiche.Salvataggio())
                Console.WriteLine("Salvatagio eseguito con successo.");
            else
                Console.WriteLine("Salvataggio non riuscito.");

        }
    }
}
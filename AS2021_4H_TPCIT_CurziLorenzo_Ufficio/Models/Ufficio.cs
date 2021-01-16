using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AS2021_4H_TPCIT_CurziLorenzo_Ufficio.Models
{
    class Ufficio
    {
        List<Pratica> _pratiche = new List<Pratica>();

        //inserimento di una nuova pratica richiamando il costruttore della classe Pratica e aggiungendola alla lista
        public void InserisciPratica(string nome, string cognome, char tipologia, string descrizione)
        {
            _pratiche.Add(new Pratica(nome, cognome, tipologia, descrizione));
        }

        //Ricerca di una pratica dato il codice
        public string RicercaPraticaCodice(int codice)
        {
            string retVal = "";

            for (int i = 0; i < _pratiche.Count; i++)
            {
                //cerco la pratica avente il codice ricevuto
                if (_pratiche[i].Codice == codice)
                {
                    retVal = _pratiche[i].ToString();
                }
                else
                    retVal = "\nPratica non trovata.";
            }

            return retVal;
        }

        //Ricerca di tutte le pratiche data una tipologia
        public string RicercaPraticheTipo(char tipologia)
        {
            string retVal = "";

            bool flag = false;

            for (int i = 0; i < _pratiche.Count; i++)
            {
                //cerco le pratiche della tipolgia ricevuta
                if (_pratiche[i].Tipo == tipologia)
                {
                    retVal += "\n" + _pratiche[i].ToString();
                    flag = true;
                }
            }

            if (!flag)
                retVal = "Non è stata trovata nessuna pratica.";

            return retVal;
        }

        //Eliminazione di una pratica dato il codice. Restituisce un bool indicante la riusicta o meno dell'operazione
        public bool EliminazionePratica(int codice)
        {
            int j = -1; //variabile in cui mi segno l'indice in cui si trova la pratica da eliminare
            for (int i = 0; i < _pratiche.Count; i++)
            {
                if (_pratiche[i].Codice == codice)
                    j = i;
            }

            if (j != -1)
            {
                _pratiche.RemoveAt(j);
                return true;
            }
            else
                return false;
        }

        //Salvataggio su file delle pratiche rimaste in coda. Restituisce un bool indicante la riusicta o meno dell'operazione
        public bool Salvataggio()
        {
            string salvataggio = $"\n\nSalvataggio {DateTime.Now}";

            foreach (var p in _pratiche)
            {
                salvataggio += $"\n{p.ToString()}";
            }

            try
            {
                File.AppendAllText("Salvataggio.txt", salvataggio);
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}

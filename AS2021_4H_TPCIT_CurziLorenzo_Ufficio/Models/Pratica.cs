using System;
using System.Collections.Generic;
using System.Text;

namespace AS2021_4H_TPCIT_CurziLorenzo_Ufficio.Models
{
    class Pratica
    {
        //attrivuto statico che conta le pratiche create e che userò per assegnare il codice automatico
        static int numeroPratiche = 0;


        //nome dell'utente richiedente la pratica
        string _nome;

        //cognome dell'utente richiedente la pratica
        string _cognome;

        //codice identificativo della pratica
        int _codice;

        //tipologia della pratica (A, B, C)
        char _tipo;

        //breve descrizione del contenuto della pratica
        string _descrizione;

        //Property di sola lettura
        public string Nome { get => _nome; }

        public string Cognome { get => _cognome; }

        public int Codice { get => _codice; }

        public char Tipo { get => _tipo; }

        public string Descrizione { get => _descrizione; }

        //costruttore di default
        public Pratica() { }

        //costruttore con parametri che verrà richiamato dal metodo InserisciPratica della classe Ufficio
        public Pratica(string nome, string cognome, char tipologia, string desccrizione)
        {
            //aggiorno la variabile che conta le pratiche create
            numeroPratiche++;

            _nome = nome;
            _cognome = cognome;
            _codice = numeroPratiche;
            _tipo = tipologia;
            _descrizione = desccrizione;
        }

        public override string ToString()
        {
            return $"\nNumero pratica : \t{_codice}" +
                    $"\nTipologia pratica: \t{_tipo}" +
                    $"\nCliente: \t\t{_nome} {_cognome}" +
                    $"\nDescrizione pratica: \t{_descrizione}";
        }
    }
}
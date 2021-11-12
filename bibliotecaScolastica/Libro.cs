using System;
using System.Collections.Generic;
using System.Text;

namespace bibliotecaScolastica
{
    class Libro
    {
        //memorizzare l’autore, il titolo, l’anno di pubblicazione, l’editore e il numero di pagine.
        private string _autore,_titolo,annoDiPubblicazione,editore;
        private int _nPagine;
        public string Autore { get; set; }
        public string Titolo { get; set; }
        public string AnnoPubblicazione { get; set; }
        public string Editore { get; set; }
        public int nPagine { get; set; }
        public Libro(string autore, string titolo, string anno, string editore, int npag)
        {
            Autore = autore;
            Titolo = titolo;
            AnnoPubblicazione = anno;
            Editore = editore;
            nPagine = npag;
        }

    }
}

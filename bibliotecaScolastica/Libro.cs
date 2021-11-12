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
        /*readingTime che restituisce un tempo di lettura pari a 1h se le pagine sono inferiori a 100, un valore pari
        a 2h se le pagine sono comprese tra 100 e 200 e un tempo superiore alle 2h se le pagine sono in
quantitativo superiore a 200.*/
        public int ReadingTime(int npg)
        {
            int readingTime=0;
            if (npg < 100)
            {
                readingTime = 1;
            }
            else if (npg >= 100 && npg <= 200)
            {
                readingTime = 2;
            }
            else if (npg > 200)
            {
                Random r = new Random();
                readingTime = r.Next(2, 4);
            }
            return readingTime;
        }
        public override string ToString()
        {
            return Autore + "" + Titolo + "" + AnnoPubblicazione + "" + Editore + "" + nPagine;
        }

    }
}

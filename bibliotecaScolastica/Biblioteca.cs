using System;
using System.Collections.Generic;
using System.Text;

namespace bibliotecaScolastica
{
    class Biblioteca
    {
        /*Branch Biblioteca: sviluppare la classe biblioteca che consenta di memorizzare il nome, l’indirizzo e gli orari di
apertura e chiusura giornaliera, che contenga l’elenco dei libri e consenta l’utilizzo delle operazioni sopra
elencate.
         */
        private string _nome, _indirizzo, _orarioApertura,_orarioChiusura;
        private List<Libro> _libri;
        public string Nome { get; set; }
        public string Indirizzo { get; set; }
        public string OrarioApertura { get; set; }
        public string OrarioChiusura { get; set; }
        public Biblioteca(string n,string i,string oa,string oc)
        {
            Nome = n;
            Indirizzo = i;
            OrarioApertura = oa;
            OrarioChiusura = oc;
            _libri = new List<Libro>();
        }
        public void AggiungiLibro(Libro l)
        {
            _libri.Add(l);
        }
        public Libro RicercaLibroTitolo(string titolo)
        {
            Libro libro;
            foreach(LIbro l in _libri)
            {
                if (titolo == l.Titolo)
                {
                    libro=l;
                }
            }
            return libro;
        }
        public List<Libro> RicercaLibroTitolo(string autore)
        {
            List<Libro> libriAutore = new List<Libro>();
            foreach (LIbro l in _libri)
            {
                if (autore == l.autore)
                {
                    libriAutore.Add(l);
                }
            }
            return libriAutore;
        }
    }
}

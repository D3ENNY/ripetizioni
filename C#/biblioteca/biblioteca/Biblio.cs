using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    internal class Biblio
    {
        private string _nome;
        private Libro[] _libri = new Libro[5];

        public Biblio(string nome)
        {
            this._nome = nome;
        }

        public string AggiungiLibro(Libro book)
        {
            for (int i = 0; i < this._libri.Length; i++)
            {
                if (this._libri[i] is not Libro)
                {
                    this._libri[i] = book;
                    return "Libro inserito correttamente";
                }
            }

            return "Il catalogo per questa Biblioteca è pieno";
        }

        public string MostraLibriDisponibili()
        {
            string output = $"""
                =======================
                || LIBRI DISPONIBILI ||
                =======================
                """;
            for (int i = 0; i < this._libri.Length; i++)
            {
                if (this._libri[i] != null)
                {
                    Libro libro = this._libri[i];
                    if (libro.disponibilita)
                    {
                        output += $"""
                        Titolo: {libro.titolo}
                        Autore: {libro.autore}
                        Anno di uscita: {libro.annoUscita}
                        =======================
                        """;
                    }
                }
            }
            return output;
        }

        public string prestitoLibro(string titolo)
        {
            for (int i = 0; i < this._libri.Length; i++)
            {
                if (this._libri[i] != null)
                {
                    Libro libro = this._libri[i];
                    if (libro.titolo.ToLower() == titolo.ToLower())
                    {
                        if (libro.Presta())
                        {
                            return "Libro prestato";
                        }
                        return "Libro non disponibile";
                    }
                }
            }
            return $"il libro {titolo} non è presente in biblioteca";
        }

    }
}

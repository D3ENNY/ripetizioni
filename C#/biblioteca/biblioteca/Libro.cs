using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    internal class Libro
    {
        private string _titolo;
        private string _autore;
        private int _annoUscita;
        private bool _disponibilita;

        public Libro(string titolo, string autore, int annoUscita)
        {
            this._titolo = titolo;
            this._autore = autore;
            this._annoUscita = annoUscita;
            this._disponibilita = true; //di default quando un libro viene aggiunto si assume che sia disponibile
        }

        public override string ToString()
        {
            return $"""
                    ====================
                    || DETTAGLI LIBRO ||
                    ====================
                    titolo: {this._titolo}
                    Autore: {this._autore}
                    Anno uscita: {this._annoUscita}
                    Disponibile? {(this._disponibilita ? "si" : "no")}
                """;
        }

        public bool disponibilita
        {
            get { return this._disponibilita; }
        }

        public string titolo
        {
            get { return this._titolo; }
        }
        public string autore
        {
            get { return this._autore; }
        }
        public int annoUscita
        {
            get { return this._annoUscita; }
        }

        public bool Presta()
        {
            if (this._disponibilita)
            {
                this._disponibilita = false;
                return true;
            }
            return false;
        }

        public bool Restituisce()
        {
            if (!this._disponibilita)
            {
                this._disponibilita = false;
                return true;
            }
            return false;
        }
    }
}

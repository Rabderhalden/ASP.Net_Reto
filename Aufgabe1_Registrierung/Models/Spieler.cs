using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aufgabe1_Registrierung.Models
{
    public class Spieler
    {
        public Spieler()
        {
        }

        private string _vorname;
        private string _nachname;
        private string _email;
        private string _telefon;
        private string _jahrgang;


        public string vorname
        {
            get { return _vorname; }
            set { _vorname = value; }
        }

        public string nachname
        {
            get { return _nachname; }
            set { _nachname = value; }
        }

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string telefon
        {
            get { return _telefon; }
            set { _telefon = value; }
        }

        public string jahrgang
        {
            get { return _jahrgang; }
            set { _jahrgang = value; }
        }

    }
}

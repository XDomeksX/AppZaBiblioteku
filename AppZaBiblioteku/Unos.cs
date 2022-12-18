using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppZaBiblioteku
{
    internal class Unos
    {
        string idKnjige, idKorisnika;
        DateTime datum;

        public Unos(string idKnjige, string idKorisnika, DateTime datum)
        {
            this.IdKnjige = idKnjige;
            this.IdKorisnika = idKorisnika;
            this.Datum = datum;
        }

        public string IdKnjige { get => idKnjige; set => idKnjige = value; }
        public string IdKorisnika { get => idKorisnika; set => idKorisnika = value; }
        public DateTime Datum { get => datum; set => datum = value; }

        public override string ToString()
        {
            return "ID knjige: " + IdKnjige + "\r\nID korisnika: " + IdKorisnika + "\r\nDatum: " + Datum;
        }
    }
}

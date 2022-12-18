using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppZaBiblioteku
{
    internal class Pregled
    {
        string idKnjige, idKorisnika;

        public Pregled(string idKnjige, string idKorisnika)
        {
            this.IdKnjige = idKnjige;
            this.IdKorisnika = idKorisnika;
        }

        public string IdKnjige { get => idKnjige; set => idKnjige = value; }
        public string IdKorisnika { get => idKorisnika; set => idKorisnika = value; }

        public override string ToString()
        {
            return "ID knjige: " + IdKnjige + "\r\nID korisnika: " + IdKorisnika;
        }
    }
}

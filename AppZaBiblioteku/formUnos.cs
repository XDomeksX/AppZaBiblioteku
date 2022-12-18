using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace AppZaBiblioteku
{
    public partial class formUnos : Form
    {
        List<Unos> unosi = new List<Unos>();
        string document = "Unosi.xml";
        public formUnos()
        {
            InitializeComponent();
        }

        private void BTNunesi_Click(object sender, EventArgs e)
        {
            Unos unos = new Unos(TXTidKnjige.Text, TXTidKorisnika.Text, DTPposuđivanja.Value);
            unosi.Add(unos);
            DialogResult upit = MessageBox.Show("Želite li unjeti još knjiga?", "Upit", MessageBoxButtons.YesNo);

            if (upit == DialogResult.Yes)
            {
                TXTidKnjige.Clear();
                TXTidKorisnika.Clear();
                if (File.Exists(document))
                {
                    var XMLunosi = XDocument.Load(document);

                    foreach (Unos o in unosi)
                    {
                        var ForUnos = new XElement("Unos",
                            new XElement("ID_knjige", unos.IdKnjige),
                            new XElement("ID_korisnika", unos.IdKorisnika),
                            new XElement("Datum_posudenja", unos.Datum),
                            new XElement("Datum_vraćanja", unos.Datum.AddDays(14)));
                        XMLunosi.Root.Add(ForUnos);
                    }
                    XMLunosi.Save(document);
                }
                else if (!File.Exists(document))
                {
                    var XMLunosi = new XDocument();
                    XMLunosi.Add(new XElement("Unosi"));

                    foreach (Unos o in unosi)
                    {
                        var ForUnos = new XElement("Unos",
                            new XElement("ID_knjige", unos.IdKnjige),
                            new XElement("ID_korisnika", unos.IdKorisnika),
                            new XElement("Datum_posudenja", unos.Datum),
                            new XElement("Datum_vraćanja", unos.Datum.AddDays(14)));
                        XMLunosi.Root.Add(ForUnos);
                    }
                    XMLunosi.Save(document);
                }
            }
            else
            {
                if (File.Exists(document))
                {
                    var XMLunosi = XDocument.Load(document);

                    foreach (Unos o in unosi)
                    {
                        var ForUnos = new XElement("Unos",
                            new XElement("ID_knjige", unos.IdKnjige),
                            new XElement("ID_korisnika", unos.IdKorisnika),
                            new XElement("Datum_posudenja", unos.Datum),
                            new XElement("Datum_vraćanja", unos.Datum.AddDays(14)));
                        XMLunosi.Root.Add(ForUnos);
                    }
                    XMLunosi.Save(document);
                }
                else if (!File.Exists(document))
                {
                    var XMLunosi = new XDocument();
                    XMLunosi.Add(new XElement("Unosi"));

                    foreach (Unos o in unosi)
                    {
                        var ForUnos = new XElement("Unos",
                            new XElement("ID_knjige", unos.IdKnjige),
                            new XElement("ID_korisnika", unos.IdKorisnika),
                            new XElement("Datum_posudenja", unos.Datum),
                            new XElement("Datum_vraćanja", unos.Datum.AddDays(14)));
                        XMLunosi.Root.Add(ForUnos);
                    }
                    XMLunosi.Save(document);
                }
                this.Close();
            }
        }
    }
}

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
    public partial class formPregled : Form
    {
        string document = @"D:\Visual Studio\C#\AppZaBiblioteku\AppZaBiblioteku\bin\Debug\Unosi.xml";
        public formPregled()
        {
            InitializeComponent();
        }

        private void BTNpregledaj_Click(object sender, EventArgs e)
        {
           /* Pregled pregled = new Pregled(TXTidKnjige.Text, TXTidKorisnika.Text);

            var xmlFile = XDocument.Load(document);

            var result = from s in xmlFile
                         where s.ID_knjige.Contains(TXTidKnjige.Text)
                         select s;

            foreach (var s in result)
            {
                Console.WriteLine(s.ID_kmjige);
            }*/
            XElement root = XElement.Load(document);
            IEnumerable<XElement> address =
                from el in root.Elements("Unos")
                where el.ID_knjige.Contains("")
                select el;
            foreach (XElement el in address)
                Console.WriteLine(el);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppZaBiblioteku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void BTNupis_Click(object sender, EventArgs e)
        {
            formUnos unos = new formUnos();
            unos.Show();
        }

        private void BTNpregled_Click(object sender, EventArgs e)
        {
            formPregled pregled = new formPregled();
            pregled.Show();
        }

        private void BTNpretraga_Click(object sender, EventArgs e)
        {
            formPretraga pretraga = new formPretraga();
            pretraga.Show();
        }
    }
}

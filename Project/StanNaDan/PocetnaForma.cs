using StanNaDan.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StanNaDan
{
    public partial class PocetnaForma : Form
    {
        public PocetnaForma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NekretnineForm forma = new NekretnineForm();
            forma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VlasniciForm forma = new VlasniciForm();
            forma.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NajmoviForm forma = new NajmoviForm();
            forma.ShowDialog();
        }
    }
}

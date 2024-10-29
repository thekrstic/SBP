using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StanNaDan.Forme
{
    public partial class IzmeniVlasnikaFizicko : Form
    {
        VlasnikBasic vlasnik;
        public IzmeniVlasnikaFizicko(VlasnikBasic vlasnik)
        {
            InitializeComponent();
            textBox6.MaxLength = 13;
            this.vlasnik = vlasnik;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

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
    public partial class DodajVlasnikaPravno : Form
    {
        NekretninaBasic nekretnina;
        public DodajVlasnikaPravno(NekretninaBasic n)
        {
            InitializeComponent();
            nekretnina = n;

            textBox6.MaxLength = 9;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            VlasnikBasic v = new VlasnikBasic();
            v.Ime = textBox1.Text;
            v.Prezime = textBox2.Text;
            v.Adresa = textBox3.Text;
            v.Mesto = textBox4.Text;
            v.Drzava = comboBox1.SelectedItem.ToString();
            //v.Naziv = textBox5.Text;
            //v.PIB = textBox6.Text;
            v.Nekretnine.Add(nekretnina);
            //DTOManager.DodajVlasnika(v);
            MessageBox.Show("Uspesno ste dodali novog vlasnika!");
            this.Close();
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

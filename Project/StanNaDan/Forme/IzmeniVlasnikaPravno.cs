using StanNaDan.Entiteti;
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
    public partial class IzmeniVlasnikaPravno : Form
    {
        NekretninaBasic nekretnina;
        VlasnikBasic vlasnik;
        public IzmeniVlasnikaPravno()
        {
            InitializeComponent();
        }

        public IzmeniVlasnikaPravno(VlasnikBasic v, NekretninaBasic n)
        {
            InitializeComponent();
            vlasnik = v;
            nekretnina = n;
        }

        public void popuniPodacima()
        {
            textBox1.Text = vlasnik.Ime;
            textBox2.Text = vlasnik.Prezime;
            textBox3.Text = vlasnik.Adresa;
            textBox4.Text = vlasnik.Mesto;
            comboBox1.SelectedItem = vlasnik.Drzava;
            //textBox5.Text = vlasnik.Naziv;
            //textBox6.Text = vlasnik.PIB;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            VlasnikBasic v = new VlasnikBasic();
            v.Ime = textBox1.Text;
            v.Prezime = textBox2.Text;
            v.Adresa = textBox3.Text;
            v.Mesto = textBox4.Text;
            //v.Drzava = comboBox1.SelectedItem.ToString();
            //v.Naziv = textBox5.Text;
            //v.PIB = textBox6.Text;
            v.Nekretnine.Add(nekretnina);

            //DTOManager.AzurirajVlasnika(v, v.Id);
            MessageBox.Show("Uspesno ste izmenili vlasnika!");
            this.Close();
        }
    }
}

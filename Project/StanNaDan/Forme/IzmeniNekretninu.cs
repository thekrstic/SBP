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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StanNaDan.Forme
{
    public partial class IzmeniNekretninu : Form
    {

        public NekretninaBasic nekretnina;
        public KucaBasic kuca;
        public StanBasic stan;
        public SobaBasic soba;
        public IzmeniNekretninu(NekretninaBasic ne)
        {
            InitializeComponent();
            nekretnina = ne;
            //kuca = DTOManager.GetKucaPregled(ne.ID);
            //stan = new StanBasic();
            //soba = new SobaBasic();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izmenite ovu nekretninu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da izmenite ovu nekretninu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                if (comboBox1.SelectedItem.ToString() == "Kuća")
                {
                    this.kuca.TipNekretnine = comboBox1.SelectedItem.ToString();
                    this.kuca.ImeUlice = textBox2.Text;
                    this.kuca.KucniBroj = int.Parse(textBox3.Text);
                    this.kuca.Kvadratura = int.Parse(textBox4.Text);
                    this.kuca.TipKreveta = comboBox2.SelectedItem.ToString();
                    this.kuca.Dimenzije = textBox14.Text;
                    this.kuca.BrojKupatila = (int)numericUpDown1.Value;
                    this.kuca.BrojTerasa = (int)numericUpDown2.Value;
                    this.kuca.BrojSoba = (int)numericUpDown3.Value;
                    this.kuca.Spratnost = (int)numericUpDown4.Value;
                    this.kuca.Internet = checkBox1.Checked ? 1 : 0;
                    this.kuca.TV = checkBox2.Checked ? 1 : 0;
                    this.kuca.Kuhinja = checkBox3.Checked ? 1 : 0;
                    this.kuca.Dvoriste = checkBox4.Checked ? 1 : 0;
                    this.kuca.Vlasnik = new VlasnikBasic(Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text),
                                                        listView1.SelectedItems[0].SubItems[1].Text,
                                                        listView1.SelectedItems[0].SubItems[2].Text,
                                                        listView1.SelectedItems[0].SubItems[3].Text,
                                                        listView1.SelectedItems[0].SubItems[4].Text,
                                                        listView1.SelectedItems[0].SubItems[5].Text,
                                                        listView1.SelectedItems[0].SubItems[6].Text);

                    this.kuca.Kvart = new KvartBasic(listView2.SelectedItems[0].SubItems[0].Text,
                                                        listView2.SelectedItems[0].SubItems[1].Text);

                    if (listView1.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("Izaberite vlasnika za novu nekretninu!");
                        return;
                    }
                    else if (listView2.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("Izaberite kvart za novu nekretninu!");
                        return;
                    }
                    else
                    {
                        DTOManager.DodajKucu(kuca);
                    }
                }
                else if (comboBox1.SelectedItem.ToString() == "Stan")
                {
                    this.stan.TipNekretnine = comboBox1.SelectedItem.ToString();
                    this.stan.ImeUlice = textBox2.Text;
                    this.stan.KucniBroj = int.Parse(textBox3.Text);
                    this.stan.Kvadratura = int.Parse(textBox4.Text);
                    this.stan.TipKreveta = comboBox2.SelectedItem.ToString();
                    this.stan.Dimenzije = textBox14.Text;
                    this.stan.BrojKupatila = (int)numericUpDown1.Value;
                    this.stan.BrojTerasa = (int)numericUpDown2.Value;
                    this.stan.BrojSoba = (int)numericUpDown3.Value;
                    this.stan.Internet = checkBox1.Checked ? 1 : 0;
                    this.stan.TV = checkBox2.Checked ? 1 : 0;
                    this.stan.Kuhinja = checkBox3.Checked ? 1 : 0;
                    this.stan.Sprat = (int)numericUpDown5.Value;
                    this.stan.Lift = checkBox5.Checked ? 1 : 0;

                    this.stan.Vlasnik = new VlasnikBasic(Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text),
                                                        listView1.SelectedItems[0].SubItems[1].Text,
                                                        listView1.SelectedItems[0].SubItems[2].Text,
                                                        listView1.SelectedItems[0].SubItems[3].Text,
                                                        listView1.SelectedItems[0].SubItems[4].Text,
                                                        listView1.SelectedItems[0].SubItems[5].Text,
                                                        listView1.SelectedItems[0].SubItems[6].Text);

                    this.stan.Kvart = new KvartBasic(listView2.SelectedItems[0].SubItems[0].Text,
                                                        listView2.SelectedItems[0].SubItems[1].Text);

                    if (listView1.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("Izaberite vlasnika za novu nekretninu!");
                        return;
                    }
                    else if (listView2.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("Izaberite kvart za novu nekretninu!");
                        return;
                    }
                    else
                    {
                        DTOManager.DodajStan(stan);
                    }
                }
                else if (comboBox1.SelectedItem.ToString() == "Soba")
                {
                    this.soba.TipNekretnine = comboBox1.SelectedItem.ToString();
                    this.soba.ImeUlice = textBox2.Text;
                    this.soba.KucniBroj = int.Parse(textBox3.Text);
                    this.soba.Kvadratura = int.Parse(textBox4.Text);
                    this.soba.TipKreveta = comboBox2.SelectedItem.ToString();
                    this.soba.Dimenzije = textBox14.Text;
                    this.soba.BrojKupatila = (int)numericUpDown1.Value;
                    this.soba.BrojTerasa = (int)numericUpDown2.Value;
                    this.soba.BrojSoba = (int)numericUpDown3.Value;
                    this.soba.Internet = checkBox1.Checked ? 1 : 0;
                    this.soba.TV = checkBox2.Checked ? 1 : 0;
                    this.soba.Kuhinja = checkBox3.Checked ? 1 : 0;

                    this.soba.Vlasnik = new VlasnikBasic(Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text),
                                                        listView1.SelectedItems[0].SubItems[1].Text,
                                                        listView1.SelectedItems[0].SubItems[2].Text,
                                                        listView1.SelectedItems[0].SubItems[3].Text,
                                                        listView1.SelectedItems[0].SubItems[4].Text,
                                                        listView1.SelectedItems[0].SubItems[5].Text,
                                                        listView1.SelectedItems[0].SubItems[6].Text);

                    this.soba.Kvart = new KvartBasic(listView2.SelectedItems[0].SubItems[0].Text,
                                                        listView2.SelectedItems[0].SubItems[1].Text);

                    if (listView1.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("Izaberite vlasnika za novu nekretninu!");
                        return;
                    }
                    else if (listView2.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("Izaberite kvart za novu nekretninu!");
                        return;
                    }
                    else
                    {
                        DTOManager.DodajSobu(soba);
                    }
                }

                if (comboBox1.SelectedItem.ToString() == "Kuća" ||
                    comboBox1.SelectedItem.ToString() == "Stan" ||
                    comboBox1.SelectedItem.ToString() == "Soba")
                {
                    MessageBox.Show("Uspesno ste dodali novu nekretninu!");
                    this.Close();
                }
                else
                {
                    string poruka1 = "Izaberite Tip Nekretnine";
                    string title1 = "Pitanje";
                    MessageBoxButtons buttons1 = MessageBoxButtons.OKCancel;
                    DialogResult result1 = MessageBox.Show(poruka1, title1, buttons1);
                }
            }
            else
            {

            }
        }

        private void IzmeniNekretninu_Load(object sender, EventArgs e)
        {
            if (nekretnina.TipNekretnine == "KUCA")
            {
                comboBox1.SelectedIndex = 1;
                textBox2.Text = this.kuca.ImeUlice;
                textBox3.Text = this.kuca.KucniBroj.ToString();
                textBox4.Text = this.kuca.Kvadratura.ToString();
                int tipKreveta = 0;
                if (kuca.TipKreveta == "krevet za 1 osobu") tipKreveta = 1;
                if (kuca.TipKreveta == "bračni krevet") tipKreveta = 2;
                comboBox2.SelectedIndex = tipKreveta;
                textBox14.Text = this.kuca.Dimenzije;
                numericUpDown1.Value = this.kuca.BrojKupatila;
                numericUpDown2.Value = this.kuca.BrojTerasa;
                numericUpDown3.Value = this.kuca.BrojSoba;
                numericUpDown4.Value = this.kuca.Spratnost;
                checkBox1.Checked = (kuca.Internet == 1);
                checkBox2.Checked = (kuca.TV == 1);
                checkBox3.Checked = (kuca.Kuhinja == 1);
                checkBox4.Checked = (kuca.Dvoriste == 1);
                //listView1.SelectedItems = kuca.Vlasnik;
                this.kuca.Vlasnik = new VlasnikBasic(Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text),
                                                    listView1.SelectedItems[0].SubItems[1].Text,
                                                    listView1.SelectedItems[0].SubItems[2].Text,
                                                    listView1.SelectedItems[0].SubItems[3].Text,
                                                    listView1.SelectedItems[0].SubItems[4].Text,
                                                    listView1.SelectedItems[0].SubItems[5].Text,
                                                    listView1.SelectedItems[0].SubItems[6].Text);

                this.kuca.Kvart = new KvartBasic(listView2.SelectedItems[0].SubItems[0].Text,
                                                    listView2.SelectedItems[0].SubItems[1].Text);

                if (listView1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite vlasnika za novu nekretninu!");
                    return;
                }
                else if (listView2.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite kvart za novu nekretninu!");
                    return;
                }
                else
                {
                    DTOManager.DodajKucu(kuca);
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Stan")
            {
                this.stan.TipNekretnine = comboBox1.SelectedItem.ToString();
                this.stan.ImeUlice = textBox2.Text;
                this.stan.KucniBroj = int.Parse(textBox3.Text);
                this.stan.Kvadratura = int.Parse(textBox4.Text);
                this.stan.TipKreveta = comboBox2.SelectedItem.ToString();
                this.stan.Dimenzije = textBox14.Text;
                this.stan.BrojKupatila = (int)numericUpDown1.Value;
                this.stan.BrojTerasa = (int)numericUpDown2.Value;
                this.stan.BrojSoba = (int)numericUpDown3.Value;
                this.stan.Internet = checkBox1.Checked ? 1 : 0;
                this.stan.TV = checkBox2.Checked ? 1 : 0;
                this.stan.Kuhinja = checkBox3.Checked ? 1 : 0;
                this.stan.Sprat = (int)numericUpDown5.Value;
                this.stan.Lift = checkBox5.Checked ? 1 : 0;

                this.stan.Vlasnik = new VlasnikBasic(Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text),
                                                    listView1.SelectedItems[0].SubItems[1].Text,
                                                    listView1.SelectedItems[0].SubItems[2].Text,
                                                    listView1.SelectedItems[0].SubItems[3].Text,
                                                    listView1.SelectedItems[0].SubItems[4].Text,
                                                    listView1.SelectedItems[0].SubItems[5].Text,
                                                    listView1.SelectedItems[0].SubItems[6].Text);

                this.stan.Kvart = new KvartBasic(listView2.SelectedItems[0].SubItems[0].Text,
                                                    listView2.SelectedItems[0].SubItems[1].Text);

                if (listView1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite vlasnika za novu nekretninu!");
                    return;
                }
                else if (listView2.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite kvart za novu nekretninu!");
                    return;
                }
                else
                {
                    DTOManager.DodajStan(stan);
                }
            }
            else if (comboBox1.SelectedItem.ToString() == "Soba")
            {
                this.soba.TipNekretnine = comboBox1.SelectedItem.ToString();
                this.soba.ImeUlice = textBox2.Text;
                this.soba.KucniBroj = int.Parse(textBox3.Text);
                this.soba.Kvadratura = int.Parse(textBox4.Text);
                this.soba.TipKreveta = comboBox2.SelectedItem.ToString();
                this.soba.Dimenzije = textBox14.Text;
                this.soba.BrojKupatila = (int)numericUpDown1.Value;
                this.soba.BrojTerasa = (int)numericUpDown2.Value;
                this.soba.BrojSoba = (int)numericUpDown3.Value;
                this.soba.Internet = checkBox1.Checked ? 1 : 0;
                this.soba.TV = checkBox2.Checked ? 1 : 0;
                this.soba.Kuhinja = checkBox3.Checked ? 1 : 0;

                this.soba.Vlasnik = new VlasnikBasic(Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text),
                                                    listView1.SelectedItems[0].SubItems[1].Text,
                                                    listView1.SelectedItems[0].SubItems[2].Text,
                                                    listView1.SelectedItems[0].SubItems[3].Text,
                                                    listView1.SelectedItems[0].SubItems[4].Text,
                                                    listView1.SelectedItems[0].SubItems[5].Text,
                                                    listView1.SelectedItems[0].SubItems[6].Text);

                this.soba.Kvart = new KvartBasic(listView2.SelectedItems[0].SubItems[0].Text,
                                                    listView2.SelectedItems[0].SubItems[1].Text);

                if (listView1.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite vlasnika za novu nekretninu!");
                    return;
                }
                else if (listView2.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Izaberite kvart za novu nekretninu!");
                    return;
                }
                else
                {
                    DTOManager.DodajSobu(soba);
                }
            }

            if (comboBox1.SelectedItem.ToString() == "Kuća" ||
                comboBox1.SelectedItem.ToString() == "Stan" ||
                comboBox1.SelectedItem.ToString() == "Soba")
            {
                MessageBox.Show("Uspesno ste dodali novu nekretninu!");
                this.Close();
            }
            else
            {
                string poruka1 = "Izaberite Tip Nekretnine";
                string title1 = "Pitanje";
                MessageBoxButtons buttons1 = MessageBoxButtons.OKCancel;
                DialogResult result1 = MessageBox.Show(poruka1, title1, buttons1);
            }
        }
    }
}

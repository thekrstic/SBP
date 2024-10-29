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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace StanNaDan.Forme
{
    public partial class DodajNekretninu : Form
    {
        public NekretninaBasic nekretnina;
        public KucaBasic kuca;
        public StanBasic stan;
        public SobaBasic soba;
        public DodajNekretninu()
        {
            InitializeComponent();
            nekretnina = new NekretninaBasic();
            kuca = new KucaBasic();
            stan = new StanBasic();
            soba = new SobaBasic();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Da li zelite da dodate novu nekretninu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                if (comboBox1.SelectedItem.ToString() == "Kuća")
                {
                    this.kuca.TipNekretnine = "KUCA";
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
                    this.stan.TipNekretnine = "STAN";
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
                    this.soba.TipNekretnine = "SOBA";
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
                    else if(listView2.SelectedItems.Count == 0)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Kuća")
            {
                numericUpDown4.Enabled = true;
                checkBox4.Enabled = true;
                numericUpDown5.Enabled = false;
                checkBox5.Enabled = false;
            }
            else if (comboBox1.SelectedItem.ToString() == "Stan")
            {
                numericUpDown5.Enabled = true;
                checkBox5.Enabled = true;
                numericUpDown4.Enabled = false;
                checkBox4.Enabled = false;
            }
            else if (comboBox1.SelectedItem.ToString() == "Soba")
            {
                numericUpDown5.Enabled = false;
                checkBox5.Enabled = false;
                numericUpDown4.Enabled = false;
                checkBox4.Enabled = false;
            }
        }

        private void DodajNekretninu_Load(object sender, EventArgs e)
        {
            List<VlasnikPregled> listaVlasnika = DTOManager.GetVlasnikePregled();
            this.listView1.Items.Clear();

            foreach (VlasnikPregled vb in listaVlasnika)
            {
                ListViewItem item = new ListViewItem(new string[] { vb.Id.ToString(), vb.TipVlasnika, vb.Ime, vb.Prezime, vb.Adresa, vb.Mesto, vb.Drzava });
                this.listView1.Items.Add(item);
            }
            this.listView1.Refresh();


            List<KvartPregled> kvartovi = DTOManager.GetKvartPregled();


            foreach (KvartPregled k in kvartovi)
            {
                ListViewItem item = new ListViewItem(new string[] { k.Naziv, k.Zona });
                this.listView2.Items.Add(item);
            }
            this.listView2.Refresh();
        }
    }
}

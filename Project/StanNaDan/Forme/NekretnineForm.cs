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
    public partial class NekretnineForm : Form
    {
        public NekretnineForm()
        {
            InitializeComponent();
        }

        public int brojNekretnina;

        private void NekretnineForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            this.brojNekretnina = 0;

            List<NekretninaPregled> listaNekretnina = DTOManager.GetNekretninaPregled();
            this.listView1.Items.Clear();


            foreach (NekretninaPregled np in listaNekretnina)
            {
                KucaPregled kuca = null;
                StanPregled stan = null;
                SobaPregled soba = null;

                if (np == null)
                {
                    MessageBox.Show("NekretninaPregled objekat je null.");
                    continue;
                }
                //MessageBox.Show(np.GetType().ToString());

                string tip = "";
                kuca = DTOManager.GetKucaPregled(np.ID);
                stan = DTOManager.GetStanPregled(np.ID);
                soba = DTOManager.GetSobaPregled(np.ID);

                if (kuca != null)
                    tip = "KUCA";
                else if (stan != null)
                    tip = "STAN";
                else if (soba != null)
                    tip = "SOBA";


                ListViewItem item = new ListViewItem(new string[] { np.ID.ToString(), tip, np.KucniBroj.ToString(),
                                                                    np.ImeUlice, np.Kvadratura.ToString(), np.BrojKupatila.ToString(),
                                                                    np.BrojTerasa.ToString(), np.BrojSoba.ToString(), np.Internet.ToString(),
                                                                    np.TV.ToString(), np.Kuhinja.ToString(), np.Dimenzije, np.TipKreveta});
                this.listView1.Items.Add(item);
                this.brojNekretnina++;

            }

            textBox1.Text = this.brojNekretnina.ToString();
            this.listView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DodajNekretninu forma = new DodajNekretninu();
            forma.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite nekretninu koju zelite da obrišete!");
                return;
            }

            int idNekretnine = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrišete izabranu nekretninu?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                if (DTOManager.ObrisiNekretninu(idNekretnine) == true)
                {
                    MessageBox.Show("Brisanje nekretnine je uspešno obavljeno!");
                }
                else
                {
                    MessageBox.Show("Brisanje nekretnine je NEUSPESNO!");
                }
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite nekretninu čije podatke želite da izmenite!");
                return;
            }

            int idNekretnine = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            NekretninaBasic ne = DTOManager.GetNekretninaPregled(idNekretnine);

            IzmeniNekretninu formaUpdate = new IzmeniNekretninu(ne);
            formaUpdate.ShowDialog();

            this.popuniPodacima();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite Nekretninu cijeg Vlasnika zelite da vidite!");
                return;
            }

            int idNekretnine = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            VlasnikPregled v = DTOManager.GetPregledVlasnikNekretnine(idNekretnine);

            MessageBox.Show("Vlasnik: " + v.Id + ", " + v.Ime + ", " + v.Prezime + ", "
                            + v.TipVlasnika + ", " + v.Adresa + ", " + v.Mesto + ", " + v.Drzava);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite Nekretninu cijeg Vlasnika [fizicko lice] zelite da vidite!");
                return;
            }

            int idVlasnika = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            /*VlasnikBasic vb = DTOManager.vratiProdavnicu(idProdavnice);
            VlasnikNekretnineFizickoLice forma = new VlasnikNekretnineFizickoLice(vb);
            forma.ShowDialog();*/
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BrojeviRacunaVlasnika forma = new BrojeviRacunaVlasnika();
            forma.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite Nekretninu ciji Kvart zelite da vidite!");
                return;
            }

            int idNekretnine = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            KvartPregled k = DTOManager.GetPregledKvartNekretnine(idNekretnine);

            MessageBox.Show("Kvart: " + k.Naziv + ", " + k.Zona);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite Nekretninu ciji Vas Sajtovi zanimaju!");
                return;
            }
            else
            {
                int idNekretnine = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                SajtoviNekretnine forma = new SajtoviNekretnine(idNekretnine);
                forma.ShowDialog();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite Nekretninu cija Vas oprema zanima!");
                return;
            }
            else
            {
                int idNekretnine = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
                DodatnaOpremaNekretnine forma = new DodatnaOpremaNekretnine(idNekretnine);
                forma.ShowDialog();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            popuniPodacima();
        }
    }
}

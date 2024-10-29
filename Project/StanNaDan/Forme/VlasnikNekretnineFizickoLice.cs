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
    public partial class VlasnikNekretnineFizickoLice : Form
    {
        NekretninaBasic nekretnina;
        public VlasnikNekretnineFizickoLice(NekretninaBasic nb)
        {
            InitializeComponent();
            nekretnina = nb;
        }

        private void VlasnikNekretnineFizickoLice_Load(object sender, EventArgs e)
        {
            //this.Text = "NEKRETNINA " + nekretnina.Vlasnik.ToUpper();
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listView1.Items.Clear();
            /*List<VlasnikNekretninePravnoLice> podaci = DTOManager.vratiOdeljenjaDo5Prodavnice(nekretnina.Id);

            foreach (VlasnikNekretninePravnoLice v in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.OdeljenjeId.ToString(), p.Lokacija, p.BrojKasa.ToString(), p.InfoPult });
                listView1.Items.Add(item);
            }*/

            listView1.Refresh();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //DodajVlasnikaFizicko forma = new DodajVlasnikaFizicko(nekretnina);
            //forma.ShowDialog();
            popuniPodacima();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vlasnika ciji broj telefona zelite da vidite!");
                return;
            }

            int idVlasnika = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            VlasnikBasic vlasnik = null;
            //VlasnikBasic vlasnik = DTOManager.vratiOdeljenjaDo5(idOdeljenja);
            BrojTelefonaFizicko forma = new BrojTelefonaFizicko(vlasnik);
            forma.ShowDialog();
            popuniPodacima();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vlasnika cije podatke zelite da izmenite!");
                return;
            }

            int idOdeljenja = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            VlasnikBasic vlasnik = null;
            //VlasnikBasic vlasnik = DTOManager.vratiOdeljenjaDo5(idOdeljenja);
            IzmeniVlasnikaFizicko forma = new IzmeniVlasnikaFizicko(vlasnik);
            forma.ShowDialog();
            popuniPodacima();
        }
    }
}

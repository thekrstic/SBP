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
    public partial class BrojTelefonaPravno : Form
    {
        VlasnikBasic vlasnik;
        public BrojTelefonaPravno()
        {
            InitializeComponent();
        }

        public BrojTelefonaPravno(VlasnikBasic v)
        {
            InitializeComponent();
            vlasnik = v;
        }

        public void popuniPodacima()
        {
            listView1.Items.Clear();
            //List<VlasnikBasic> podaci = DTOManager.vratiProizvodeOdeljenjaDo5(odeljenje.OdeljenjeId);

            /*foreach (VlasnikBasic v in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] { p.ProdajeProzivod.BarKod.ToString(), p.ProdajeProzivod.Tip.ToString(),
                    p.ProdajeProzivod.Naziv.ToString(), p.ProdajeProzivod.Proizvodjac.ToString(), p.Id.ToString() });
                listView1.Items.Add(item);
            }*/

            listView1.Refresh();
        }

        private void BrojTelefonaPravno_Load(object sender, EventArgs e)
        {
            //this.Text = "ODELJENJE DO 5 GOD., MESTO " + listView1.Lokacija.ToUpper();
            popuniPodacima();
        }
    }
}

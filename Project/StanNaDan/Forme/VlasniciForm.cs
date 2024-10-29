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
    public partial class VlasniciForm : Form
    {
        public VlasniciForm()
        {
            InitializeComponent();
        }

        public int brojVlasnika = 0;
        private void VlasniciForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            this.brojVlasnika = 0;

            List<VlasnikPregled> listaVlasnika = DTOManager.GetVlasnikePregled();
            this.listView1.Items.Clear();

            foreach (VlasnikPregled vb in listaVlasnika)
            {
                ListViewItem item = new ListViewItem(new string[] { vb.Id.ToString(), vb.TipVlasnika, vb.Ime, vb.Prezime, vb.Adresa, vb.Mesto, vb.Drzava});
                this.listView1.Items.Add(item);
                this.brojVlasnika++;
            }

            textBox1.Text = this.brojVlasnika.ToString();
            this.listView1.Refresh();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vlasnika koga zelite da obrisete!");
                return;
            }

            int idVlasnika = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabranog vlasnika?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                if (listView1.SelectedItems[0].SubItems[2].Text == "FIZICKO_LICE")
                {
                    if (DTOManager.ObrisiFizickoLice(idVlasnika) == true)
                    {
                        MessageBox.Show("Brisanje vlasnika je uspesno obavljeno!");
                    }
                    else
                    {
                        MessageBox.Show("Brisanje vlasnika je NEUSPESNO!");
                    }
                }
                else if (listView1.SelectedItems[0].SubItems[2].Text == "PRAVNO_LICE")
                {
                    if (DTOManager.ObrisiPravnoLice(idVlasnika) == true)
                    { 
                        MessageBox.Show("Brisanje vlasnika je uspesno obavljeno!");
                    }
                    else
                    {
                        MessageBox.Show("Brisanje vlasnika je NEUSPESNO!");
                    }
                }
                MessageBox.Show(listView1.SelectedItems[0].SubItems[3].Text); //ne selektuje tipVlasnika??
                this.popuniPodacima();
            }
            else
            {

            }
        }
    }
}

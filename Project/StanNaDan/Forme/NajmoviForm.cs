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
    public partial class NajmoviForm : Form
    {
        public NajmoviForm()
        {
            InitializeComponent();
        }

        public int brojNajmova = 0;

        private void NajmoviForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
        public void popuniPodacima()
        {
            this.brojNajmova = 0;

            List<NajamPregled> listaNajmova = DTOManager.GetNajamPregled();
            this.listView1.Items.Clear();

            foreach (NajamPregled np in listaNajmova)
            {
                ListViewItem item = new ListViewItem(new string[] { np.ID.ToString(), np.DatumOd.ToString(), np.DatumDo.ToString(), np.CenaPoDanu.ToString(), np.BrojDana.ToString(), np.Popust.ToString(), np.Provizija.ToString() });
                this.listView1.Items.Add(item);
                this.brojNajmova++;
            }

            textBox1.Text = this.brojNajmova.ToString();
            this.listView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite najam koji zelite da obrisete!");
                return;
            }

            int idNajma = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li zelite da obrisete izabrani najam?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                if (DTOManager.ObrisiNajam(idNajma) == true)
                    MessageBox.Show("Brisanje najma je uspesno obavljeno!");
                else
                    MessageBox.Show("Brisanje najma je NEUSPESNO!");
                this.popuniPodacima();
            }
            else
            {

            }
        }
    }
}

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
    public partial class SajtoviNekretnine : Form
    {
        List<SajtoviPregled> listaSajtova;
        NekretninaBasic nekretnina;
        public SajtoviNekretnine(int idN)
        {
            InitializeComponent();
            listaSajtova = DTOManager.vratiSajtoveNekretnine(idN);
            nekretnina = DTOManager.GetNekretninaPregled(idN);

        }

        private void popuni()
        {
            this.listView1.Items.Clear();
            foreach (SajtoviPregled sp in listaSajtova)
            {
                if (sp == null)
                {
                    MessageBox.Show("SajtoviPregled objekat je null.");
                    continue;
                }

                ListViewItem item = new ListViewItem(new string[] { sp.ID.ToString(), sp.Sajt });
                this.listView1.Items.Add(item);
            }
            this.listView1.Refresh();
        }
        private void SajtoviNekretnine_Load(object sender, EventArgs e)
        {
            popuni();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && textBox1.Text.StartsWith("www."))
            {
                string sajt = textBox1.Text;

                int maxId = 0;
                foreach (ListViewItem item in listView1.Items)
                {
                    int currentId = int.Parse(item.SubItems[0].Text);
                    if (currentId > maxId)
                    {
                        maxId = currentId;
                    }
                }

                SajtoviBasic sb = new SajtoviBasic(maxId + 1, sajt, nekretnina);

                if (DTOManager.DodajSajtoveBasic(sb) == true) // vraca false zbog ID??
                {
                    MessageBox.Show("Uspesno dodat sajt!");
                }
                else
                {
                    MessageBox.Show("Sajt NIJE dodat!");
                }

                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = false;
                textBox1.Clear();
                textBox1.Visible = false;

                popuni();
            }
            else
            {
                MessageBox.Show("Tekst mora da počinje sa 'www.'!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            popuni();
        }
    }
}

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
    public partial class DodatnaOpremaNekretnine : Form
    {
        List<DodatnaOpremaPregled> listaOpreme;
        NekretninaBasic nekretnina;
        public DodatnaOpremaNekretnine(int idN)
        {
            InitializeComponent();
            listaOpreme = DTOManager.vratiOpremuNekretnine(idN);
            nekretnina = DTOManager.GetNekretninaPregled(idN);
        }

        private void DodatnaOpremaNekretnine_Load(object sender, EventArgs e)
        {
            foreach (DodatnaOpremaPregled dop in listaOpreme)
            {
                if (dop == null)
                {
                    MessageBox.Show("DodatnaOpremaPregled objekat je null.");
                    continue;
                }

                ListViewItem item = new ListViewItem(new string[] { dop.ID.ToString(), dop.Tip, dop.Cena.ToString() });
                this.listView1.Items.Add(item);
            }
            this.listView1.Refresh();
        }
    }
}

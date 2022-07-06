using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1055D_NEAGU_CHRIS_MARIOS
{
    public partial class Form1 : Form
    {
        Comanda c;
        public Form1()
        {
            InitializeComponent();
            c = new Comanda("Client");
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (String.IsNullOrEmpty(tbDenumire.Text))
                errorProvider1.SetError(tbDenumire, "Denumirea este empty");
            else if (String.IsNullOrEmpty(tbPret.Text))
                errorProvider1.SetError(tbPret, "Pret este empty");
            else if (String.IsNullOrEmpty(tbCantitate.Text))
                errorProvider1.SetError(tbCantitate,"Cantitate este empty");
            else
            {
                string denumire = tbDenumire.Text;
                float pret = float.Parse(tbPret.Text);
                int cantitate = int.Parse(tbCantitate.Text);
                c.adaugaProdus(new Produs(denumire, pret, cantitate));
                tbDenumire.Clear();
                tbPret.Clear();
                tbCantitate.Clear();
                MessageBox.Show("Produsul a fost adaugat cu succes!");
            }
            
        }

        private void btnArata_Click(object sender, EventArgs e)
        {
            lvProduse.Items.Clear();
            ListViewItem item;

            foreach (Produs p in c.LISTA_PRODUSE)
            {
                item = new ListViewItem(p.DENUMIRE);
                item.SubItems.Add(p.PRET.ToString());
                item.SubItems.Add(p.CANTITATE.ToString());
                item.SubItems.Add(p.VALOARE.ToString());
                lvProduse.Items.Add(item);
            }
        }

        private void salveazaTXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine(c.NUME_CLIENT);
                foreach (Produs p in c.LISTA_PRODUSE)
                {
                    sw.Write(p.ToString());
                }
                sw.WriteLine(c.calculeazaTotalCos().ToString());
                sw.Close();
            }
        }
    }
}

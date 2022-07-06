using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROIECT_PAW
{
    public partial class Cumparare : Form
    {
        private Cont c;
        public Cumparare(Cont c)
        {
            this.c = c;

            c.btRezultat.PerformClick();

            InitializeComponent();

            populare();

            lvCumparare.ContextMenuStrip = contextMenuStrip1;

        }

        private void populare()
        {


            ListViewItem lv = new ListViewItem("TES");
            lv.SubItems.Add("Tesla");
            lv.SubItems.Add("4");
            lv.SubItems.Add("120");
            lv.SubItems.Add("130");
            lv.SubItems.Add("170");
            lv.SubItems.Add("03-04-2021");
            lv.SubItems.Add("680");
            lvCumparare.Items.Add(lv);


            lv = new ListViewItem("UBE");
            lv.SubItems.Add("Uber");
            lv.SubItems.Add("10");
            lv.SubItems.Add("39.45");
            lv.SubItems.Add("42.58");
            lv.SubItems.Add("40.22");
            lv.SubItems.Add("15-06-2022");
            lv.SubItems.Add("402.2");
            lvCumparare.Items.Add(lv);
        }

        private void cumparaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvCumparare.Items)
            {
                if (item.Checked)
                {
                    if (c.cont.Depuneri > double.Parse(item.SubItems[item.SubItems.Count - 1].Text))
                    {
                        
                        c.cont.ListaActiuni.Add(new Actiune(item.Text, item.SubItems[1].Text,
                            int.Parse(item.SubItems[2].Text), double.Parse(item.SubItems[3].Text), double.Parse(item.SubItems[4].Text),
                            double.Parse(item.SubItems[5].Text), DateTime.Parse(item.SubItems[6].Text)));
                        c.cont.Depuneri -= double.Parse(item.SubItems[item.SubItems.Count - 1].Text);
                        item.Remove();
                    }
                    else
                    {
                        MessageBox.Show("Sold insuficient");
                    }
                  
                }
            }

            c.restart();
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PROIECT_PAW
{
    public partial class Cont : Form
    {
        public Portofoliu cont;
        List<Actiune> actiuni;
        public Cont(Portofoliu p)
        {
            cont = p;
            actiuni = new List<Actiune>();
            InitializeComponent();
            
        }

        private void salveazaRaportTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                string linie;
                sw.WriteLine(cont.Depuneri);
                foreach (Actiune a in cont.ListaActiuni)
                {
                  
                    linie = a.SIMBOL + ",";
                    linie += a.SOCIETATE + ",";
                    linie += a.CANTITATE + ",";
                    linie += a.PRET + ",";
                    linie += a.REFERINTA + ",";
                    linie += a.P_ACHIZITIE + ",";
                    linie += a.DATA + ",";
                    sw.WriteLine(linie);
                }
                sw.Close();
            }
        }

        private void deschideRaportTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*txt)|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lvCont.Items.Clear();
                cont.ListaActiuni.Clear();
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string linie;
                Actiune a;
                cont.Depuneri = double.Parse(sr.ReadLine());
                while ((linie = sr.ReadLine()) != null)
                {
                    string simbol = linie.Split(',')[0];
                    string societate = linie.Split(',')[1];
                    int cantitate = int.Parse(linie.Split(',')[2]);
                    double pret = double.Parse(linie.Split(',')[3]);
                    double referinta = double.Parse(linie.Split(',')[4]);
                    double achizitie = double.Parse(linie.Split(',')[5]);
                    DateTime dateTime = DateTime.Parse(linie.Split(',')[6]);
                    a = new Actiune(simbol, societate, cantitate, pret, referinta, achizitie, dateTime);
                    cont.ListaActiuni.Add(a);
                    afisareInView(a);
                }
                
                sr.Close();
            }
        }

        public void restart()
        {
            lvCont.Items.Clear();
            foreach(Actiune a in cont.ListaActiuni)
            {
                afisareInView(a);
            }
        }
        private void afisareInView(Actiune a)
        {
            ListViewItem lvitem = new ListViewItem(a.SIMBOL);
            lvitem.SubItems.Add(a.SOCIETATE);
            lvitem.SubItems.Add(a.CANTITATE.ToString());
            lvitem.SubItems.Add(a.PRET.ToString());
            lvitem.SubItems.Add(a.P_ACHIZITIE.ToString());
            lvitem.SubItems.Add(a.EVOLUTIE.ToString("0.00")+"%");
            lvitem.SubItems.Add(a.VALOARE.ToString("0.00"));
            lvCont.Items.Add(lvitem);
            
        }
        private void salveazaRaportBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("raport.dat", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, cont.Depuneri);
            bf.Serialize(fs, cont.ListaActiuni);
            fs.Close();
            MessageBox.Show("Datele au fost criptate intr-un fisier binar");
        }

        private void deschideRaportBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("raport.dat", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            cont.ListaActiuni.Clear();
            cont.Depuneri = (double) bf.Deserialize(fs);
            cont.ListaActiuni = (List<Actiune>) bf.Deserialize(fs);
            lvCont.Items.Clear();

            
            foreach(Actiune a in cont.ListaActiuni)
            {
                afisareInView(a);
            }
            fs.Close();
        }

        private void btRezultat_Click(object sender, EventArgs e)
        {
            tbDepuneri.Text = cont.Depuneri.ToString();
        }

        private void lvSell_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void lvSell_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(List<ListViewItem>)))
            {
                var items = (List<ListViewItem>)e.Data.GetData(typeof(List<ListViewItem>));

                foreach (ListViewItem lvi in items)
                {

                    cont.ListaActiuni.RemoveAt(lvCont.Items.IndexOf(lvCont.SelectedItems[0]));
                    lvi.ListView.Items.Remove(lvi);
                    
                    lvSell.Items.Add(lvi);
                }
            }
            
        }

        private void lvCont_ItemDrag(object sender, ItemDragEventArgs e)
        {
            
            var items = new List<ListViewItem>();
           
            items.Add((ListViewItem)e.Item);
           
            foreach (ListViewItem lvi in lvCont.SelectedItems)
            {
                if (!items.Contains(lvi))
                {
                    items.Add(lvi);
                }
            }
           
            lvCont.DoDragDrop(items, DragDropEffects.Move);
        }

        private void btSell_Click(object sender, EventArgs e)
        {
            double suma = 0;
            foreach (ListViewItem item in lvSell.Items)
            {
                suma += double.Parse(item.SubItems[item.SubItems.Count-1].Text);
               
            }
            cont.Depuneri += suma;
            btRezultat.PerformClick();
            lvSell.Items.Clear();
            
        }

        private void btCalculeaza_Click(object sender, EventArgs e)
        {

             cont.Calculeaza_Valoare();
             tbValoare.Text = cont.Valoare.ToString();
        }

        private void scriereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();

          
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);

            XmlElement element1 = doc.CreateElement(string.Empty, "catalog", string.Empty);
            doc.AppendChild(element1);

          

            foreach (Actiune a in cont.ListaActiuni)
            {
                XmlElement element2 = doc.CreateElement(string.Empty, "Actiune", string.Empty);
                element1.AppendChild(element2);

                XmlElement element3 = doc.CreateElement(string.Empty, "Simbol", string.Empty);
                XmlText text1 = doc.CreateTextNode(a.SIMBOL);
                element3.AppendChild(text1);
                element2.AppendChild(element3);

                XmlElement element4 = doc.CreateElement(string.Empty, "Emitent", string.Empty);
                XmlText text2 = doc.CreateTextNode(a.SOCIETATE);
                element4.AppendChild(text2);
                element2.AppendChild(element4);

                XmlElement element5 = doc.CreateElement(string.Empty, "Cantitate", string.Empty);
                XmlText text3 = doc.CreateTextNode(a.CANTITATE.ToString());
                element5.AppendChild(text3);
                element2.AppendChild(element5);

                XmlElement element6 = doc.CreateElement(string.Empty, "Ultimul_Pret", string.Empty);
                XmlText text4 = doc.CreateTextNode(a.PRET.ToString());
                element6.AppendChild(text4);
                element2.AppendChild(element6);

                XmlElement element7 = doc.CreateElement(string.Empty, "Pret_referinta", string.Empty);
                XmlText text5 = doc.CreateTextNode(a.REFERINTA.ToString());
                element7.AppendChild(text5);
                element2.AppendChild(element7);

                XmlElement element8 = doc.CreateElement(string.Empty, "Pret_achizitie", string.Empty);
                XmlText text6 = doc.CreateTextNode(a.P_ACHIZITIE.ToString());
                element8.AppendChild(text6);
                element2.AppendChild(element8);

                XmlElement element9 = doc.CreateElement(string.Empty, "Data", string.Empty);
                XmlText text7 = doc.CreateTextNode(a.DATA.ToString());
                element9.AppendChild(text7);
                element2.AppendChild(element9);
         

            }

            doc.Save("Portofoliu.xml");
        }

        private void citireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load("Portofoliu.xml");
            XmlNodeList xmlNodeList = xmlDocument.SelectNodes("/catalog");
            cont.ListaActiuni.Clear();

            foreach (XmlNode xnc in xmlNodeList)
            {
                XmlNodeList xmlNodeListD = xnc.ChildNodes;
                foreach (XmlNode xnC in xmlNodeListD)
                {

                   
                    string simbol = xnC["Simbol"].InnerText;
                    string emitent = xnC["Emitent"].InnerText;
                    int cantitate = int.Parse(xnC["Cantitate"].InnerText);
                    double ultim_pret = double.Parse(xnC["Ultimul_Pret"].InnerText);
                    double pret_referinta = double.Parse(xnC["Pret_referinta"].InnerText);
                    double pret_achizitie = double.Parse(xnC["Pret_achizitie"].InnerText);
                    DateTime dt = DateTime.Parse(xnC["Data"].InnerText);
                    Actiune a = new Actiune(simbol,emitent,cantitate,ultim_pret,pret_referinta,pret_achizitie,dt);
                    afisareInView(a);
                    cont.ListaActiuni.Add(a);
                    
                }
            }

           
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            lvCont.Items.Clear();
            cont.ListaActiuni.Clear();
        }

        private void deseneazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Desen ds = new Desen(cont.ListaActiuni);
            ds.Show();
        }

        private void cumparaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cumparare cp = new Cumparare(this);
            cp.Show();
        }
    }
}

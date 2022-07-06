using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1055D_NEAGU_CHRIS_MARIOS
{
    class Comanda : ITotal
    {
        private string numeClient;
        private List<Produs> listaProduse;

        public Comanda(string numeClient)
        {
            this.numeClient = numeClient;
            listaProduse = new List<Produs>();
        }

        public string NUME_CLIENT
        {
            get => numeClient;
            set => numeClient=value;
        }

        public List<Produs> LISTA_PRODUSE
        {
            get => listaProduse;
            set => listaProduse = value;
        }
        public override string ToString()
        {
            string mesaj = numeClient + Environment.NewLine;
            foreach (Produs p in listaProduse) 
            {
                mesaj += p.ToString();
            }
            return mesaj;
        }

        public void adaugaProdus(Produs p)
        {
            this.listaProduse.Add(p);
        }

        public float calculeazaTotalCos()
        {
            float total = 0;
            foreach (Produs p in listaProduse)
            {
                total += p.PRET * p.CANTITATE;
            }
            return total;
        }
    }
}

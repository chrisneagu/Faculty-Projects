using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1055D_NEAGU_CHRIS_MARIOS
{
    class Produs
    {
        private string denumire;
        private float pret;
        private int cantitate;

        public Produs(string denumire, float pret, int cantitate)
        {
            this.denumire = denumire;
            this.pret = pret;
            this.cantitate = cantitate;
        }

        public string DENUMIRE
        {
            get => denumire;
            set => denumire = value;
        }

        public float PRET
        {
            get => pret;
            set => pret = value;
        }

        public int CANTITATE
        {
            get => cantitate;
            set => cantitate = value;
        }

        public float VALOARE
        {
            get => cantitate * pret;
        }
        public override string ToString()
        {
            return DENUMIRE + " " + pret.ToString() + " " + cantitate.ToString() + Environment.NewLine;
        }
    }
}

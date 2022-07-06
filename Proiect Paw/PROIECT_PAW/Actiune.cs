using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_PAW
{
    [Serializable]
    public class Actiune
    {

        private string Simbol;
        private string Societate;
        private int cantitate;
        private double ultimul_pret;
        private double pret_referinta; 
        private double pret_achizitie;
        private DateTime data;
       
        private double valoare;
        private double variatie;
        private float evolutie;

        public Actiune(string simbol, string societate, int cantitate, double ultimul_pret, double pret_referinta, double pret_achizitie, DateTime data)
        {
            Simbol = simbol;
            Societate = societate;
            this.cantitate = cantitate;
            this.ultimul_pret = ultimul_pret;
            this.pret_referinta = pret_referinta;
            this.pret_achizitie = pret_achizitie;
            this.data = data;
            Calcul_Evolutie();
            Calcul_Valoare();
            Calcul_Variatie();
        }

        public Actiune(string simbol, string societate, int cantitate, double ultimul_pret, double pret_referinta, double pret_achizitie)
        {
            Simbol = simbol;
            Societate = societate;
            this.cantitate = cantitate;
            this.ultimul_pret = ultimul_pret;
            this.pret_referinta = pret_referinta;
            this.pret_achizitie = pret_achizitie;
            Calcul_Evolutie();
            Calcul_Valoare();
            Calcul_Variatie();
        }
        public void Calcul_Evolutie()
        {
            evolutie = (float) ((ultimul_pret - pret_achizitie) / pret_achizitie * 100);
            
        }

        public double EVOLUTIE
        {
            get => evolutie;
        }

        public void Calcul_Valoare()
        {
            valoare = cantitate * ultimul_pret;
        }

        public void Calcul_Variatie()
        {
            variatie = (ultimul_pret - pret_referinta) / pret_referinta * 100;
        }

        public double P_ACHIZITIE
        {
            get=>pret_achizitie;
        }
        public string SOCIETATE
        {
            get => Societate;
            set => Societate = value;
        }

        public string SIMBOL
        {
            get => Simbol;
        }
        public double REFERINTA
        {
            get => pret_referinta;
        }

        public double PRET //ultimul pret
        {
            get => ultimul_pret;
            set => ultimul_pret = value;
        }


        public int CANTITATE
        {
            get => cantitate;
            set => cantitate = value;
        }


        public DateTime DATA
        {
            get => data;
            set => data = value;
        }

        public double VARIATIE
        {
            get => variatie;
        }

        public double VALOARE
        {
            get => valoare;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Smibol: " + Simbol + " ");
            sb.Append("Societate: " + Societate + " ");
            sb.Append("Pret de Referinta: " + pret_referinta + " ");
            sb.Append("Ultimul Pret: " + ultimul_pret + " ");
            sb.Append("Valoare: " + valoare + " ");
            sb.Append("Variatie: " + variatie + " ");
            sb.Append("DATA: " + data.ToString("dd/MM/yyyy HH:mm:ss")+Environment.NewLine);
            return sb.ToString();
        }

    }
}

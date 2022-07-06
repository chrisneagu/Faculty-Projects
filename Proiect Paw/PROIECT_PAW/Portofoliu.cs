using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_PAW
{
    [Serializable]
    public class Portofoliu : ICalculValoare,IComparable<Portofoliu>
    {
        private string nume_detinator;
        private string email;
        private string telefon;
        private List<Actiune> actiuni;
        private double depuneri;
        private double valoare;

        public Portofoliu(string nume_detinator, string email, string telefon, double depuneri)
        {
            this.nume_detinator = nume_detinator;
            this.email = email;
            this.telefon = telefon;
            this.depuneri = depuneri;
            actiuni = new List<Actiune>();
            
        }

        public Portofoliu(string nume_detinator, string email, string telefon)
        {
            this.nume_detinator = nume_detinator;
            this.email = email;
            this.telefon = telefon;
            this.depuneri = 0;
            actiuni = new List<Actiune>();

        }

        public double Depuneri
        {
            get => depuneri;
            set => depuneri = value;
        }

        public string NUME
        {
            get => nume_detinator;
            set => nume_detinator = value;
        }

        public string EMAIL
        {
            get => email;
            set => email = value;
        }

        public string TELEFON
        {
            get => telefon;
            set => telefon = value;
        }


        public List<Actiune> ListaActiuni
        {
            get => actiuni;
            set
            {
                if (value != null)
                {
                    actiuni = value;
                }
            }
        }

        public double Valoare
        {
            get => valoare;
        }

        public Actiune this[int index]
        {
            get {
                if (index < 0)
                    throw new ArgumentOutOfRangeException("index");
                return actiuni[index];
            }
        
            set => actiuni[index] = value;
        }

        public void AdaugaActiune(Actiune a)
        {
            actiuni.Add(a);
        }

        public void Calculeaza_Valoare()
        {
            double suma = 0;
            foreach(Actiune actiune in actiuni)
            {
                suma += actiune.CANTITATE * actiune.PRET;
            }
            valoare = suma;
        }

        public void Calcul_Taxe(float procent)
        {
           
        }

       
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Proprietar: " + nume_detinator + " ");
            sb.Append("Email: " + email + " ");
            sb.Append("Telefon: " + telefon + " ");
            foreach(Actiune a in actiuni)
            {
                sb.Append(a.ToString());
            }
            return sb.ToString();
        }

        public object Clone()
        {
            Portofoliu aux = (Portofoliu)this.MemberwiseClone();
            return aux;
        }

        public int CompareTo(Portofoliu other)
        {
            return this.valoare.CompareTo(other.valoare);
        }

        public static Portofoliu operator+(Portofoliu p, Actiune actiune_noua) //adaugam o actiune noua in portofoliu
        {
            p.actiuni.Add(actiune_noua);
            return p;
        }

        public static explicit operator string(Portofoliu p)
        {
            return p.nume_detinator;
        }

        public static Portofoliu operator+(Portofoliu p1, Portofoliu p2) //p1 dest p2 source
        {
            p1.actiuni.AddRange(p2.actiuni); //ca si cum am lua actiunile din 2 si le punem in 1 transfer de actiuni
            return p1;
        }


    }
}

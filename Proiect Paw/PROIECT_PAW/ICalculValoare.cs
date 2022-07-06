using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROIECT_PAW
{
    interface ICalculValoare
    {

        void Calculeaza_Valoare();
        void Calcul_Taxe(float procent); //0.30 ex procent
    }
}

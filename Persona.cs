using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class Persona
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public int Stratum { get; set; }
        public string Gender { get; set; }
        public double TotalValueMonth { get; set; }

        public void calculateTotalValueGym(double salary, double discount)
        {
            if (salary >= 1000000 && salary <= 1999999){ this.TotalValueMonth = 40000 - discount; }
            else if (salary >= 2000000 && salary <= 5000000){ this.TotalValueMonth = 60000 - discount; }
            else if (salary > 5000000){ this.TotalValueMonth = 80000 - discount; }
        }

        public double calculateTotalDiscount(int stratum, char gender, double totalValueGym)
        {
            double discount = 0;
            if (stratum == 1 || stratum == 2){ discount = totalValueGym * .2; }
            else if (stratum == 3 || stratum == 4){ discount = totalValueGym * .15; }
            else if (stratum == 5 || stratum == 6){ discount = totalValueGym * .1; }

            if (gender.Equals("Femenino")) { discount += (totalValueGym * .05); }
            return discount;
        }
    }
}

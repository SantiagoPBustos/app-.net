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
        public double ValueMonth { get; set; }

        public double getTotalValueGym(double salary)
        {
            if (salary >= 1000000 && salary <= 1999999){ return 40000; }
            else if (salary >= 2000000 && salary <= 5000000) { return 60000; }
            else { return 80000; }
        }

        public double calculateDiscount(int stratum, string gender, double totalValueGym)
        {
            double discount = 0;
            if (stratum == 1 || stratum == 2){ discount = totalValueGym * .2; }
            else if (stratum == 3 || stratum == 4){ discount = totalValueGym * .15; }
            else if (stratum == 5 || stratum == 6){ discount = totalValueGym * .1; }

            if (gender.Equals("Femenino")) { discount += (totalValueGym * .05); }
            return discount;
        }

        public double calculateValueGym(double salary, int stratum, string gender)
        {
            double totalValueGym = this.getTotalValueGym(salary);
            double discount = this.calculateDiscount(stratum, gender, totalValueGym);
            this.ValueMonth = totalValueGym - discount;
            return this.ValueMonth;          
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Travel
    {
        public double residence = 2000;
        public double delivery = 1000;
        public double excursion = 400;
        public double day;
        public double human;
        public double excursionCount;
        public Travel (double day, double human, double excursionCount)
        {
            this.day = day;
            this.human = human;
            this.excursionCount = excursionCount;
        }

        public virtual double Calculation()
        {
            double cost = 0;
            cost = (residence * day) + (delivery * human) + (excursion * excursionCount);
            return cost;
        }
    }
}

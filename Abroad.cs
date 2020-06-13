using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public class Abroad:Travel
    {
        public double visa = 200;
        public Abroad(double day, double human, double excursionCount) : base(day, human, excursionCount){}

        public override double Calculation()
        {
            double cost = 0;
            cost = (residence * day) + (delivery * human * 0.3) + (excursion * excursionCount) + (visa * human);
            return cost;
        }
    }
}

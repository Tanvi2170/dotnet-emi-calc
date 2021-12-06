using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class EmiCal
    {
        internal decimal emi_calculator(decimal p,
                              decimal r, decimal t, decimal n)

        {
            decimal emi;
           r = r / (n * 100); // one month interest
           t = t * n; // one month period
            emi =(p * (decimal)Math.Pow(1 +(double)r, (double)t))
                  / t;

            return (emi);
        }
    }
}

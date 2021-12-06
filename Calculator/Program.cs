using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
            static void Main(string[] args)
            { // Driver Program'
                var spObject = new EmiCal();

            decimal principal, rate, time, emi, n;
           
            Console.WriteLine("Enter principal = ");
            principal = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter Rate=");
            rate = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter Time");
            time = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter number of compounding per year = ");
            n = Convert.ToDecimal(Console.ReadLine());



            emi = spObject.emi_calculator(principal, rate, time, n);

                Console.WriteLine("Monthly EMI is = " + emi);
                Console.ReadLine();

            }
        }
}

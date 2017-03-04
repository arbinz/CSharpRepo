using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Activate
    {
        static void Main(string[] args)
        {
            Functions f = new Functions();

            Console.WriteLine("First Number:");
            double x = Convert.ToDouble(Console.ReadLine());

            double op;

            Console.WriteLine("What Function? 1 for add, 2 for subtract, 3 for multiply, 4 for divide");
            op = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the Second Value?");
            double y = Convert.ToDouble(Console.ReadLine());

            if(op == 1)
            {
                Console.WriteLine(f.Add(x, y));
                Console.ReadKey();
            }

            else if(op == 2)
            {
                Console.WriteLine(f.Sub(x, y));
                Console.ReadKey();
            }

            else if(op == 3)
            {
                Console.WriteLine(f.Mul(x, y));
                Console.ReadKey();
            }

            else if(op == 4)
            {
                Console.WriteLine(f.Div(x, y));
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("Sorry, thats not a function!");
                Console.ReadKey();
            }
        }
    }

    class Functions
    {
        public double Add (double value1, double value2)
        {
            value1 += value2;
            return value1;
        }

        public double Div (double numerator, double denominator)
        {
            numerator /= denominator;
            return numerator;
        }

        public double Mul (double value1, double value2)
        {
            value1 *= value2;
            return value1;
        }

        public double Sub (double num, double subBy)
        {
            num -= subBy;
            return num;
        }
    }
}

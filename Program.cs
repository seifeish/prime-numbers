using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Num1= ");
            int Num1 = int.Parse(Console.ReadLine());
            Console.Write("Num2= ");
            int Num2 = int.Parse(Console.ReadLine());

            for (int n = Num1; n <= Num2; n++)
            {
                bool isPrime = true;
                int max = n / 2;

                for (int x = 2; x < max; x++)
                {
                    if (n % x == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime) Console.Write(n + " ");
            }
        }
    }
}

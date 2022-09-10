using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPrime
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the number:");
            int n = Convert.ToInt32(Console.ReadLine());
            FindPrimeNumber(n);
        }
        public static void FindPrimeNumber(int n)
        {
            if (n % 2 == 0)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                Console.WriteLine("prime");
            }
        }
    }
}

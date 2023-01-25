using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramms
{
    internal class PrimeNumber
    {
        public  void isPrimeMain() {
            Console.WriteLine("Enter the Number to check prime or not :");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine( isPrime(n));
         
        }
        public static bool isPrime(int n) {
            for (int i = 2; i <=n/2; i++)
            {
                if (n % i == 0) {
                    return false;
                }

            }
            return true; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramms
{
    internal class PerfectNumber
    {
        public  bool isPerfect()
        {
            Console.WriteLine("Enter the Number to Check Perfect Or Not :");
            int n = int.Parse(Console.ReadLine());

            int sum = 0, temp = n;
            for (int i = 1; i <= n/2; i++)
            {
                if (n%i==0)
                {
                    sum =sum+ i;
                }
             
            }
            return (sum==temp);
        }
    
    
    }
}

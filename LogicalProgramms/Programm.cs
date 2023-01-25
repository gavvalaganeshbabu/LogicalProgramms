using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace LogicalProgramms
{
    internal class Programm
    {
        public static void Main() {
            Console.WriteLine("Enter Your Choice Between This :");
            Console.WriteLine("1. For Coupon Generator Machine :");
            Console.WriteLine("2. For Perfect Number or Not :");
            Console.WriteLine("3. For Stop Watch Timer :");
            Console.WriteLine("4. For PrimeNumber Checker :");
            int n=int.Parse(Console.ReadLine());          
            switch (n){
                case 1:
                         CouponGenerator cp= new CouponGenerator();
                         cp.CouponGenerated();
                    break;
                case 2:
                         PerfectNumber  pr= new PerfectNumber();                  
                         Console.WriteLine(pr.isPerfect());
                    break;
                case 3:
                        StopWatch stp= new StopWatch();
                        stp.StopWatchTimer();
                    break;
                case 4:
                        PrimeNumber p=new PrimeNumber();                                      
                        p.isPrimeMain();
                    break;           
                default:
                        Console.WriteLine("Invalid Option :");
                    break;
            }
        }
    }
}

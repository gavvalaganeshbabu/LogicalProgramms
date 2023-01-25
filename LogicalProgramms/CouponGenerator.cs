using System;
using System.Linq;

namespace LogicalProgramms
{
    internal class CouponGenerator
    {
        

        public void CouponGenerated() {
            Console.WriteLine("Enter how Many You Want :");
            int n1 = int.Parse(Console.ReadLine());
            string[] k = new string[n1];
            string s="";
            for (int i = 0; i < n1; i++)
            {
                k[i] =   bigChar() + intRange(500, 1000) + intRange1(2000, 3000) +isString();
            }
            foreach (string i in k) { 
            Console.WriteLine(i);
            }
        }
        
        public static char bigChar() {
            Random rnd = new Random();
            int n=rnd.Next(0,26);
            char ch = (char)('A' + n);
            return ch;  
        }
        public static int intRange(int a,int b) {
            Random rnd = new Random();
            int k=rnd.Next(a,b);
            return k;  
        }
        public static int intRange1(int a, int b) {
            Random rnd = new Random();
            int k=rnd.Next(a,b);
            return k;
        }
        public static string isString() {
            Random rnd = new Random();
            int length=rnd.Next(4,8);
            string str = "";
            for (int i = 0; i < length; i++)
            {
                int n = rnd.Next(1, 26);
                char ch = Convert.ToChar(rnd.Next(n + 65));
                str += ch;

            }
            return str;

        }
    }
}

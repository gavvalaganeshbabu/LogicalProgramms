using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace LogicalProgramms
{
    internal class StopWatch
    {
        public  void StopWatchTimer() {
            string s = "";
            Stopwatch watch = new Stopwatch();
            watch.Start();
            for (int i = 0; i <= 10; i++) { 
            Thread.Sleep(10);
                
            }
            Console.WriteLine(s + watch.Elapsed);
            watch.Stop();
           
          
        }
    }
}

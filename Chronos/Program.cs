using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            //namespace: System.Diagnostics
            //public long ElapsedMilliseconds { get; }
            //System.Diagnostics.Stopwatch.IsRunning
            //System.Diagnostics.Stopwatch.StartNew()
            //System.Diagnostics.Stopwatch.Stop()

            float tempo1 = 0.0f;
            float tempo2 = 0.0f;
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();
            crono1.Start();
            Thread.Sleep(600);
            crono2.Start();
            Thread.Sleep(800);
            crono1.Stop();
            crono2.Stop();

            tempo1 = crono1.ElapsedMilliseconds;
            tempo2 = crono2.ElapsedMilliseconds;
            String.Format("{0:0.###}", tempo1);
            String.Format("{0:0.###}", tempo2);

            Console.WriteLine(tempo1);
            Console.WriteLine(tempo2);
        }
    }
}

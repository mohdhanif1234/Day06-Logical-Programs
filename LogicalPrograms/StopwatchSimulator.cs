using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;


namespace LogicalPrograms
{
    class StopwatchSimulator
    {
        public static void StopwatchSimulatorMethod()
        {
            // Create new stopwatch.
            Stopwatch stopwatch = new Stopwatch();

            // Begin timing.
            stopwatch.Start();

            // Do something.
            for (int i = 0; i < 1000; i++)
            {
                Thread.Sleep(1);
            }

            // Stop timing.
            stopwatch.Stop();

            // Display result.
            Console.WriteLine("Time elapsed: {0} seconds", stopwatch.Elapsed);
            Console.ReadLine();
        }
    }
}

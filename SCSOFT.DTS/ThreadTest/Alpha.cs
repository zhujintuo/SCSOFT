using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTest
{
    public class Alpha
    {
        private void Beta()
        {
            while (true)
            {
                Console.WriteLine("Alpha.Beta is running in its own thread.");
            }
        }

        public int Test()
        {
            Console.WriteLine("Thead Start/Stop/Join Sample");
            Thread oThread = new Thread(new ThreadStart(this.Beta));
            oThread.Start();
            while (!oThread.IsAlive)
            {
                Thread.Sleep(1);
                oThread.Abort();
                oThread.Join();

                Console.WriteLine();
                Console.WriteLine("Alpha.Beta has finished");
                try
                {
                    Console.WriteLine("Try to restart the Alpha.Beta thread");
                    oThread.Start();
                }
                catch (ThreadStateException)
                {
                    Console.WriteLine("ThreadStateException trying to restart Alpha.Beta.");
                    Console.WriteLine("Expection since aborted threads cannot be restarted");
                    Console.ReadLine();

                }
            }

            return 0;
        }
    }
}

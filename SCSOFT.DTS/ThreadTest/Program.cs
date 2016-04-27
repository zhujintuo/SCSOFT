using System; 
using System.Threading; 

namespace ThreadTest
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //Thread.CurrentThread.Name = "System Thread";
            //Console.WriteLine(Thread.CurrentThread.Name + "'Status:" + Thread.CurrentThread.ThreadState + "'");
            //Console.ReadLine();

            //Alpha alpha = new Alpha();
            //alpha.Test();

            Test.TestMain(); 
            Console.WriteLine();
        }
    }
}

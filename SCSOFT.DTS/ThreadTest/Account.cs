using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTest
{
    internal class Account
    {
        int balance;
        Random r = new Random();

        internal Account(int initial)
        {
            balance = initial;
        }

        internal int Withdraw(int amount)
        {
            if (balance < 0)
            {
                throw new Exception("Negative Balance");
            }

            lock (this)
            {
                Console.WriteLine("Current Thread：" + Thread.CurrentThread.Name);
                if (balance >= amount)
                {
                    Thread.Sleep(5);
                    balance = balance - amount;
                    return amount;
                }
                else
                    return 0;
            }
        }

        internal void DoTransactions()
        {
            for (int i = 0; i < 100; i++)
                Withdraw(r.Next(-50, 100));
        }
    }

    internal class Test
    {
        static internal Thread[] threads = new Thread[10];
        public static void TestMain()
        {
            Account acc = new Account(0);

            for (int i = 0; i < 10; i++)
            {
                Thread t = new Thread(new ThreadStart(acc.DoTransactions));
                threads[i] = t;
            }

            for (int i = 0; i < 10; i++)
                threads[i].Name = i.ToString();

            for (int i = 0; i < 10; i++)
                threads[i].Start();

            Console.ReadLine();
        }
    }
}

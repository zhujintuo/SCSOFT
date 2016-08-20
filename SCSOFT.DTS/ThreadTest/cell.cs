using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTest
{
    public class Cell
    {
        // Cell 对象里边的内容
        int cellContents;
        // 状态标志，为true时可以读取，为false则正在写入
        bool readerFlag = false;

        public int ReadFromCell()
        {
            lock (this)
            {
                if (!readerFlag) // 如果现在不可读取
                {
                    try
                    {
                        Monitor.Wait(this);
                    }
                    catch (SynchronizationLockException e)
                    {
                        Console.WriteLine(e);
                    }
                    catch (ThreadInterruptedException e)
                    {
                        Console.WriteLine(e);
                    }
                }

                Console.WriteLine("Consume：{0}", cellContents);
                readerFlag = false;

                Monitor.Pulse(this);
            }
            return cellContents; 
        }

        public void WriteToCell(int n)
        {
            lock(this)
            {
                if (readerFlag)
                {
                    try
                    {
                        Monitor.Wait(this);
                    }
                    catch (SynchronizationLockException e)
                    {
                        Console.WriteLine(e);
                    }
                    catch (ThreadInterruptedException e)
                    {
                        Console.WriteLine(e);
                    }
                }

                cellContents = n;
                Console.WriteLine("Produce：{0}",cellContents);
                readerFlag = true;
                Monitor.Pulse(this);
            }
        }
    }
}

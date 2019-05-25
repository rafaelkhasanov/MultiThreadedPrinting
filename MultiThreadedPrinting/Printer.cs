using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreadedPrinting
{
    public class Printer
    {
        private object threadLock = new object();
        public void PrintNumbers()
        {
            lock (threadLock)
            {
                //Вывести информацию о потоке
                Console.WriteLine($"-{Thread.CurrentThread.ManagedThreadId} is executing PrintNumbers()");
                //Вывести числа
                Console.Write("Your numbers: ");
                for (int i = 0; i < 10; i++)
                {
                    //Приостановить поток на случайный период времени
                    Random r = new Random();
                    Thread.Sleep(500 * r.Next(5));

                    Console.Write($"{i}, ");
                }
                Console.WriteLine();
            }
        }
    }
}

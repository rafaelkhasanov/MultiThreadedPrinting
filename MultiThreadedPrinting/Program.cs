﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreadedPrinting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Synchronizing Threads\n");
            Printer p = new Printer();
            //Создать 10 потоков, которые указывают на один и тот же метод того же самого объекта
            Thread[] threads = new Thread[10];
            for (int i = 0; i < 10; i++)
            {
                threads[i] = new Thread(new ThreadStart(p.PrintNumbers))
                {
                    Name = $"Worker thread #{i}"
                };
            }

            foreach (Thread item in threads)
                item.Start();
            Console.ReadLine();
        }
    }
}

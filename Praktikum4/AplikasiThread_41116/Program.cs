using System;
using System.Threading;

namespace AplikasiThread_41116
{
    public class myThread
    {
        public static void Thread1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("cuci baju ke {0}", i);
                Thread.Sleep(3000);
            }
        }

        public static void Thread2()
        {
            for (int i=0; i < 10; i++)
            {
                Console.WriteLine("setrika ke {0}", i);
                Thread.Sleep(3000);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("mulai melakukan pekerjaan");
            Console.WriteLine("=================================");

            Thread tid1 = new Thread(new ThreadStart(myThread.Thread1));
            Thread tid2 = new Thread(new ThreadStart(myThread.Thread2));

            tid1.Start();
            tid2.Start();
            Console.ReadLine();
        }
    }
}

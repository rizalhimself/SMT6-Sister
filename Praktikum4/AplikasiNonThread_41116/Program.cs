using System;

namespace AplikasiNonThread_41116
{
    public class non_Thread
    {
        public void cuci_baju()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("cuci baju ke{0}", i);
            }
        }
        public void setrika()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("setrika ke {0}", i);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("Mulai melakukan pekerjaan");
            Console.WriteLine("=========================================");

            non_Thread tid1 = new non_Thread();
            tid1.cuci_baju();
            tid1.setrika();

            Console.WriteLine("=========================================");
            Console.WriteLine("Selesai...!");
            Console.WriteLine("=========================================");
            Console.ReadLine();
        }
    }
}

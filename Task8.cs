/*using System;

namespace DovrlerTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zehmet olmasa 8 reqemli parolu ekrana daxil edin: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int n = 0;
            int count = 2;

            while (num > 0)
            {
                Random random = new Random();
                n = random.Next(100000000, 1000000000);
                #region random uretilen sayini gormek ucun
                *//*   Console.Write("Random uretilen sayi: ");
                   Console.WriteLine(n); *//*
                #endregion
                if (num == n)
                {
                    Console.WriteLine("Sisteme giris ugurlu oldu!");
                    break;
                }
                else
                {

                    if (num != n)
                    {
                        Console.WriteLine($"Daxil etdiyiniz parol sehvdir, sisteme girish ucun sadece {count} sansiniz qaldi");
                        count--;
                        num = Convert.ToInt32(Console.ReadLine());
                    }
                    if (count == 0)
                    {
                        Console.WriteLine("Deneme hakkiniz bitti!");
                        Thread.Sleep(10000);
                        break;
                    }
                }

            }
        }
    }
}
*/
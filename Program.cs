using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prak10._1._1
{
    class Program
    {
        static void Main (string[] args)
        {
            //18
            //try
            //{
            //    int a = 0, b = 0;
            //    Console.WriteLine("Введите кол-во строк");
            //    a = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Введите кол-во столбцов");
            //    b = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("введите занчение k:");
            //    int k = Convert.ToInt32(Console.ReadLine());
            //    Random rnd = new Random();
            //    int[,] mas = new int[a, b];
            //    for (int i = 0; i < mas.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < mas.GetLength(1); j++)
            //        {
            //            mas[i, j] = rnd.Next(-50, 50);
            //            Console.Write($"{mas[i, j],4} ");
            //        }
            //        Console.WriteLine();
            //    }


            //    //zad1
            //    int pol_k = 0;
            //    for (int i = 0; i < mas.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < mas.GetLength(1); j++)
            //        {
            //            if (mas[i, j] > 0 && mas[i, j] % k == 0)
            //                pol_k++;
            //        }
            //    }


            //    //zad2
            //    Console.WriteLine(pol_k);
            //    Console.WriteLine("введите k1");
            //    int k1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("введите k2");
            //    int k2 = Convert.ToInt32(Console.ReadLine());
            //    if (k > 0)
            //    {
            //        int[] sum = new int[mas.GetLength(0)];
            //        if (k1 >= 0 && k2 >= 0 && k1 < k2 && k2 < a && k1 < a)
            //        {
            //            for (int i = 0; i < mas.GetLength(0); i++)
            //            {
            //                for (int j = 0; j < mas.GetLength(1); j++)
            //                {
            //                    sum[i] += mas[i, j];
            //                }
            //            }

            //            for (int i = k1; i < k2; i++)
            //            {
            //                Console.WriteLine($"сумма {i + 1} строке = {sum[i]}");
            //            }
            //        }
            //    }
            //}
            //catch { Console.WriteLine("ошибка"); }



            //19
            try
            {
                int g = 0, h = 0;
                Console.WriteLine("Введите кол-во строк");
                g = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите кол-во столбцов");
                h = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("введите занчение a");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("введите занчение b");
                int b = Convert.ToInt32(Console.ReadLine());
                Random rnd = new Random();
                int[,] mas = new int[g, h];

                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    for (int j = 0; j < mas.GetLength(1); j++)
                    {
                        mas[i, j] = rnd.Next(-50, 50);
                        Console.Write($"{mas[i, j],4} ");
                    }
                    Console.WriteLine();
                }
                //zad1
                int pol_k = 0;
                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    for (int j = 0; j < mas.GetLength(1); j++)
                    {
                            if (mas[i, j] % a == 0 || mas[i, j] % b == 0)
                                pol_k++;
                    }
                }



                //zad2
                Console.WriteLine(pol_k);
                Console.WriteLine("введите k1");
                int k1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("введите k2");
                int k2 = Convert.ToInt32(Console.ReadLine());
                int proiz = 1;
                if (k1 >= 0 && k2 >= 0 && k1 < k2 && k2 < g && k1 < g)
                {
                    for (int i = 0; i < mas.GetLength(0); i++)
                    {
                        for (int j = 0; j < mas.GetLength(1); j++)
                        {
                            if (mas[i, j] < 0)
                                proiz*= mas[i, j];
                        }
                    }
                    for (int i = k1; i < k2; i++)
                    {
                        Console.WriteLine($"произведение отрицательных элементов {i + 1} строке = {proiz}");
                    }
                }
            }
            catch { Console.WriteLine("ошибка"); }
            Console.ReadKey();

        }
    }
}

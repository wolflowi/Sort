using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sort_met_Puz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] t = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите {0} элемент массива", i + 1);
                t[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (t[j] > t[i])
                    {
                        int a = t[i];
                        t[i] = t[j];
                        t[j] = a;

                    }
                }
            }

            string y = "";
            for (int i = 0; i < n; i++)
            {
                y += t[i] + " ";
            }
            Console.WriteLine(y);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, n;
            k = 0;
            
            Console.WriteLine("Введите размерность массива");
            n = int.Parse(Console.ReadLine());
            int[,] array = new int[n, n];

            for (i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (j = 0; j < n; j++)
                {
                 
                    if (i % 2 != 1)
                    {
                        if (j % 2 != 1)
                        {
                            array[i, j] = 1;
                        }                                               
                    }
                    if (i % 2 == 1)
                    {
                        if (j % 2 == 1)
                        {
                            array[i, j] = 1;
                        }
                    }
                                             
                 Console.Write(String.Format("{0,3}", array[i, j]));
                }
                Console.WriteLine();
            } Console.ReadKey();
                   

        }
    }
}

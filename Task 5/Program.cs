using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        { int i;
            int aSum;
            aSum = 0;
            int[] array = new int[7];
            for (i = 0; i < 7; i++)
            {
                Console.Write("Введите элемент массива под индексом {0}:\t", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Вы ввели следующий массив");
            for (int j = 0; j < 7; j++)
            { Console.WriteLine(array[j]); }

            for (int k = 0; k < 7; k++)
            { aSum = aSum + array[k]; }
            Console.WriteLine("Среднеарифметическое составляет {0}", (aSum / 7)); 
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.GorovenkoGV.Sprint4.Task0.V17.Lib;

namespace Tyuiu.GorovenkoGV.Sprint4.Task0.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнил: Горовенко Г.В. | ПКТб 23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Горовенко Глеб Васильевич | ПКТб-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать сумму четных   *");
            Console.WriteLine("* элементов массива.  {4 ,8 ,7 ,6 ,5 ,8 ,2 ,4 ,3 ,2}                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИССХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("***************************************************************************");


            int[] numsArray = { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.WriteLine(numsArray[i]);
            }



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Результирующая сумма:");

            int res = ds.GetSumEvenArrEl(numsArray);

            
                Console.WriteLine(res);
            

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

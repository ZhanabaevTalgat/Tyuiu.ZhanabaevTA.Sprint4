using Tyuiu.ZhanabaevTA.Sprint4.Task2.V2.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint4.Task2.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Жанабаев Т.А | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:  Одномерные массивы (генератор случайных чисел)                   *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Жанабаев Талгат Асылбекович | РППб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 11 элементов заполненный         *");
            Console.WriteLine("* случайными в диапазоне от 1 до 8 подсчитать произведение нечетных       *");
            Console.WriteLine("* элементов массива.                                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Random rn = new Random();
            int[] r = new int[11];

            for (int i = 0; i < 11; i++)
            {
                if (i == 10)
                {
                    r[i] = rn.Next(2, 8);
                    Console.Write(r[i] + " }");
                }
                else if (i == 0)
                {
                    r[i] = rn.Next(2, 8);
                    Console.Write("{ " + r[i]);
                }
                else
                {
                    r[i] = rn.Next(2, 8);
                    Console.Write(r[i] + ", ");
                }
            }
            Console.WriteLine();
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int res = ds.Calculate(r);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}

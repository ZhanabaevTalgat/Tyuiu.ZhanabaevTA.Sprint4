using Tyuiu.ZhanabaevTA.Sprint4.Task3.V27.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint4.Task3.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Жанабаев Т.А | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:  Двумерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Жанабаев Талгат Асылбекович | РППб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 3 до 7. Подсчитайте количество   *");
            Console.WriteLine("* четных элементов во всем массиве.                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("4, 3, 5, 5, 3");
            Console.WriteLine("6, 7, 4, 4, 3");
            Console.WriteLine("3, 3, 7, 3, 6");
            Console.WriteLine("3, 4, 3, 7, 7");
            Console.WriteLine("3, 5, 6, 3, 6");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int[,] ms = new int[,] { {4, 3, 5, 5, 3},
                                     {6, 7, 4, 4, 3},
                                     {3, 3, 7, 3, 6},
                                     {3, 4, 3, 7, 7},
                                     {3, 5, 6, 3, 6 } };
            int res = ds.Calculate(ms);
            Console.WriteLine(res);
        }
    }
}

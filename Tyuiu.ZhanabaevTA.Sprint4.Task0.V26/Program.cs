using Tyuiu.ZhanabaevTA.Sprint4.Task0.V26.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint4.Task0.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Жанабаев Т.А | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:  Одномерные массивы (статический вывод)                           *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Жанабаев Талгат Асылбекович | РППб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать сумму нечетных *");
            Console.WriteLine("* элементов                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] x = new int[10] { 9, 3, 7, 1, 5, 5, 3, 2, 1, 7 };
            Console.WriteLine("{9 ,3 ,7 ,1 ,5 ,5 ,3 ,2 ,1 ,7}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int res = ds.GetSumOddArrEl(x);
            Console.WriteLine("Сумма нечетных элементов массива = " + res);
            Console.ReadKey();
        }
    }
}
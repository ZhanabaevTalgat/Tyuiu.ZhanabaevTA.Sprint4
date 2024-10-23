using Tyuiu.ZhanabaevTA.Sprint4.Task4.V30.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint4.Task4.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Жанабаев Т.А | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:  Двумерные массивы (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Жанабаев Талгат Асылбекович | РППб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 3 до 7. Заменить нечетные        *");
            Console.WriteLine("* элементы на 0                                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] ms = new int[5,5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"Введите элемент {i},{j} массива");
                    ms[i,j] = Convert.ToInt32(Console.ReadLine());
                    if ( ms[i,j] < 3 && ms[i,j] > 7 )
                    {
                        Console.WriteLine("Введено неверное значение");
                    }
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int[,] res = ds.Calculate(ms);
            Console.WriteLine(res);
        }
    }
}

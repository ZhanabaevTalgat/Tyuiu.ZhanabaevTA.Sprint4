using Tyuiu.ZhanabaevTA.Sprint4.Task6.V25.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint4.Task6.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Выполнил: Жанабаев Т.А | РППб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:  Класс Array                                                      *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Жанабаев Талгат Асылбекович | РППб-24-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковой массив данных, используя класс Array подсчитайте          *");
            Console.WriteLine("* количество элементов, длина которых больше 6.                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" [\"Теннис\", \"Футбол\", \"Крикет\", \"Баскетбол\", \"Бейсбол\", \"Регби\", \"Хоккей\"]");

            string[] ms = new string[]{"Теннис", "Футбол", "Крикет", "Баскетбол", "Бейсбол", "Регби", "Хоккей"};

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int res = ds.Calculate(ms);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}

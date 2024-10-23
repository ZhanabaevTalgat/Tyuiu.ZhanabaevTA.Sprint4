using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZhanabaevTA.Sprint4.Task3.V27.Lib
{
    public class DataService : ISprint4Task3V27
    {
        public int Calculate(int[,] array)
        {
            int res = 0;

            for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < array.Length / (array.GetUpperBound(0) + 1); j++)
                {
                    if (array[i, j] % 2 == 0)
                    {
                        res++;
                    }
                }
            }

            return res;
        }
    }
}

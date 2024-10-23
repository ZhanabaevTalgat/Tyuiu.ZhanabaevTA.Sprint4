using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZhanabaevTA.Sprint4.Task5.V12.Lib
{
    public class DataService : ISprint4Task5V12
    {
        public int Calculate(int[,] matrix)
        {
            int res = 0;

            for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < matrix.Length / (matrix.GetUpperBound(0) + 1); j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        res++;
                    }
                }
            }

            return res;
        }
    }
}

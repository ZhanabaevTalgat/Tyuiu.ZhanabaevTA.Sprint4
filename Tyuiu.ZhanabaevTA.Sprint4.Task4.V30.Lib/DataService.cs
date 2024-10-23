using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZhanabaevTA.Sprint4.Task4.V30.Lib
{
    public class DataService : ISprint4Task4V30
    {
        public int[,] Calculate(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < matrix.Length / (matrix.GetUpperBound(0) + 1); j++)
                {
                    if (matrix[i, j] % 2 == 1)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            return matrix;
        }
    }
}

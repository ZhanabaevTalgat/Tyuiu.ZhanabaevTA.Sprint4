using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZhanabaevTA.Sprint4.Task1.V22.Lib
{
    public class DataService : ISprint4Task1V22
    {
        public int Calculate(int[] array)
        {
            int res = 1;

            for (int i = 0; i < 12; i++)
            {
                if (array[i] % 2 == 1)
                {
                    res *= array[i];
                }
            }

            return res;
        }
    }
}
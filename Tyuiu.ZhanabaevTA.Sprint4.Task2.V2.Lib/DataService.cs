using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZhanabaevTA.Sprint4.Task2.V2.Lib
{
    public class DataService : ISprint4Task2V2
    {
        public int Calculate(int[] array)
        {
            int res = 1;

            for (int i = 0; i < 11; i++)
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

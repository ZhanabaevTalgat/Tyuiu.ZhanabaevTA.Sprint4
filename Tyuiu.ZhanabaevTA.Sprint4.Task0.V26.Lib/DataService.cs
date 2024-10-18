using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZhanabaevTA.Sprint4.Task0.V26.Lib
{
    public class DataService : ISprint4Task0V26
    {
        public int GetSumOddArrEl(int[] array)
        {
            int res = 0;

            for (int i = 0; i < array.Length; i ++)
            {
                if (array[i] % 2 != 0)
                {
                    res += array[i];
                }
            }

            return res;
        }
    }
}
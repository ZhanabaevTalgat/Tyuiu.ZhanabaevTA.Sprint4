using Tyuiu.ZhanabaevTA.Sprint4.Task4.V30.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint4.Task4.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] ms = { {4, 5, 6 },
                          {6, 5, 7} };
            DataService ds = new DataService();
            int[,] res = ds.Calculate(ms);
            CollectionAssert.AreEqual(res, ms); 
        }
    }
}
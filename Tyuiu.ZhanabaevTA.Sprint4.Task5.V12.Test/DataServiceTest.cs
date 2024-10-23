using Tyuiu.ZhanabaevTA.Sprint4.Task5.V12.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint4.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] ms = { {-1, 5, 6 },
                          {6, 5, -2} };
            DataService ds = new DataService();
            int res = ds.Calculate(ms);
            Assert.AreEqual(2, res);
        }
    }
}
using Tyuiu.ZhanabaevTA.Sprint4.Task2.V2.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint4.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] r = new int[11] { 2, 4, 3, 5, 6, 3, 2, 8, 3, 4, 2 };
            DataService ds = new DataService();
            int res = ds.Calculate(r);
            Assert.AreEqual(135, res);
        }
    }
}
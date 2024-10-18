using Tyuiu.ZhanabaevTA.Sprint4.Task0.V26.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint4.Task0.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] x = { 1, 2, 3 };
            int res = ds.GetSumOddArrEl(x);
            Assert.AreEqual(4, res);
        }
    }
}

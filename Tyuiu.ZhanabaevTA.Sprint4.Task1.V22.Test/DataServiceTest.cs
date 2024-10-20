using Tyuiu.ZhanabaevTA.Sprint4.Task1.V22.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint4.Task1.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] r = new int[12] { 2, 4, 3, 5, 6, 3, 2, 8, 9, 3, 4, 2 };
            DataService ds = new DataService();
            int res = ds.Calculate(r);
            Assert.AreEqual(1215, res);           
        }
    }
}
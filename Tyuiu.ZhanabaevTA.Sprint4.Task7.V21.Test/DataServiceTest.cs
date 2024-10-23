using Tyuiu.ZhanabaevTA.Sprint4.Task7.V21.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint4.Task7.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string ms = "123456789333";
            int res = ds.Calculate(4,3,ms);
            Assert.AreEqual(20,res);
        }
    }
}
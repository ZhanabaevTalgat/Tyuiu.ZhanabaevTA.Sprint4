using Tyuiu.ZhanabaevTA.Sprint4.Task6.V25.Lib;

namespace Tyuiu.ZhanabaevTA.Sprint4.Task6.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] ms = new string[] { "Теннис", "Футбол", "Крикет", "Баскетбол", "Бейсбол", "Регби", "Хоккей" };
            
            int res = ds.Calculate(ms);
            Assert.AreEqual(2, res);
        }
    }
}
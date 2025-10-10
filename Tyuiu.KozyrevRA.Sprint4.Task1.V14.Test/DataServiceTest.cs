using Tyuiu.KozyrevRA.Sprint4.Task1.V14.Lib;
namespace Tyuiu.KozyrevRA.Sprint4.Task1.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        { 
            DataService ds = new DataService();
            int[] list = { 1, 5, 3, 6, 5, 4, 8, 6, 8, 4, 2, 3, 1 };
            int res = ds.Calculate(list);
            int wait = 18;
            Assert.AreEqual(res, wait);

        }
    }
}

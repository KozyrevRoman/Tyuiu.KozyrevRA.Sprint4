using Tyuiu.KozyrevRA.Sprint4.Task7.V5.Lib;
namespace Tyuiu.KozyrevRA.Sprint4.Task7.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int res = ds.Calculate(3, 3, "246813579");
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}

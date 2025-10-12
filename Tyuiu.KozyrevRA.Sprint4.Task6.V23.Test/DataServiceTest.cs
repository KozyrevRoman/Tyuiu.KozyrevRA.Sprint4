using Tyuiu.KozyrevRA.Sprint4.Task6.V23.Lib;
namespace Tyuiu.KozyrevRA.Sprint4.Task6.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        { 
            DataService ds = new DataService();

            string[] strings = { "Microsoft", "Google", "Apple", "Amazon", "Facebook", "Tesla", "Netflix" };

            int res = ds.Calculate(strings);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
}
}

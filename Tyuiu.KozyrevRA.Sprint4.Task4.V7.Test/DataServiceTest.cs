using Tyuiu.KozyrevRA.Sprint4.Task4.V7.Lib;
namespace Tyuiu.KozyrevRA.Sprint4.Task4.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int[,] inputMas =
            {
                { 3, 4, 4, 6, 4 },
                { 6, 4, 6, 4, 5 },
                { 5, 4, 4, 4, 5 },
                { 3, 5, 6, 4, 6 }
            };

            DataService ds = new DataService();
            int res = ds.Calculate(inputMas);
            int wait = 26;

            Assert.AreEqual(wait, res);
        }
    }
}

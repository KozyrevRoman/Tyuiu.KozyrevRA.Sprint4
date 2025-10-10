using Tyuiu.KozyrevRA.Sprint4.Task3.V25.Lib;
namespace Tyuiu.KozyrevRA.Sprint4.Task3.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int[,] inputMas = {
                { 7, 3, 5, 3, 6},

                {4, 6, 2, 5, 7},

                { 2, 3, 3, 3, 5},

                { 2, 7, 7, 6, 2},

                { 6, 6, 4, 3, 6},
                };

            DataService ds = new DataService();
            int res = ds.Calculate(inputMas);
            int wait = 810;
            Assert.AreEqual(wait, res);
        }
    }
}

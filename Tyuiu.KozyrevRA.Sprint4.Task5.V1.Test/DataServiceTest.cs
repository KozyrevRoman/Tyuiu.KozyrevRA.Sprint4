using Tyuiu.KozyrevRA.Sprint4.Task5.V1.Lib;
namespace Tyuiu.KozyrevRA.Sprint4.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int[,] inputMas =
            {
                { 3, 4, -4, 6, 4 },
                { 6, 4, 6, 4, 5 },
                { 5, 4, 4, 4, 0 },
                { 3, 5, 6, 4, 6 }
            };

            DataService ds = new DataService();
            int[,] res = ds.Calculate(inputMas);
            int[,] wait =
            {
                { 1, 1, -4, 1, 1 },
                { 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 }
            }; 

            CollectionAssert.AreEqual(wait, res);
        }
    }
}

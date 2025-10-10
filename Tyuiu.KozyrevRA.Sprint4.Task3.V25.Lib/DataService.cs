using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KozyrevRA.Sprint4.Task3.V25.Lib
{
    public class DataService : ISprint4Task3V25
    {
        public int Calculate(int[,] array)
        {
            int n = 1;
            for (int i = 0; i < 5; i++)
            {
                n *= array[i, 3];
            }
            return n;
        }
    }
}

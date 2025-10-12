using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KozyrevRA.Sprint4.Task6.V23.Lib
{
    public class DataService : ISprint4Task6V23
    {
        public int Calculate(string[] array)
        {
            return array.Count(x => x.Length == 6);
        }
    }
}

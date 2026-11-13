using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.VekshinGF.Sprint4.Task1.V13.Lib
{
    public class DataService : ISprint4Task1V13
    {
        public int Calculate(int[] array)
        {
            int sum = 0;

            foreach (int element in array)
            {
                if (element % 2 == 0)
                {
                    sum += element;
                }
            }

            return sum;
        }
    }
}

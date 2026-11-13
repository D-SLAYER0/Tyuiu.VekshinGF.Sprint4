using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.VekshinGF.Sprint4.Task2.V27.Lib
{
    public class DataService : ISprint4Task2V27
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

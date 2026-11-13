using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.VekshinGF.Sprint4.Task3.V12.Lib
{
    public class DataService : ISprint4Task3V12
    {
        public int Calculate(int[,] array)
        {
            int min = array[0, 2]; // начинаем с первого элемента третьего столбца

            for (int i = 1; i < array.GetLength(0); i++)
            {
                if (array[i, 2] < min)
                {
                    min = array[i, 2];
                }
            }

            return min;
        }
    }
}

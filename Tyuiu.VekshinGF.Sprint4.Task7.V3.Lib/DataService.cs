using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.VekshinGF.Sprint4.Task7.V3.Lib
{
    public class DataService : ISprint4Task7V3
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            int index = 0;

            // Преобразуем строку в матрицу n×m
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value[index].ToString());
                    index++;
                }
            }

            // Подсчитываем нечётные числа
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}

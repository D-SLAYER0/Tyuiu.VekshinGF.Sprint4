using Tyuiu.VekshinGF.Sprint4.Task2.V27.Lib;
namespace Tyuiu.VekshinGF.Sprint4.Task2.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Векшин Г. Ф. | ПИНб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (случайные значения)                           *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Векшин Г. Ф. | ПИНб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов, заполненный        *");
            Console.WriteLine("* случайными значениями в диапазоне от 2 до 7.                            *");
            Console.WriteLine("* Подсчитать сумму четных элементов массива.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int arrayLength = 13;
            int minValue = 2;
            int maxValue = 7;
            int[] array = new int[arrayLength];

            Random rand = new Random();

            Console.WriteLine("Массив (случайные значения от " + minValue + " до " + maxValue + "):");
            Console.Write("{ ");
            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = rand.Next(minValue, maxValue + 1);
                Console.Write(array[i]);
                if (i < arrayLength - 1) Console.Write(", ");
            }
            Console.WriteLine(" }");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(array);
            Console.WriteLine("Сумма четных элементов = " + result);

            Console.ReadLine();
        }
    }
}

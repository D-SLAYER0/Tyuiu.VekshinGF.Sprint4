using Tyuiu.VekshinGF.Sprint4.Task1.V13.Lib;
namespace Tyuiu.VekshinGF.Sprint4.Task1.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Векшин Г. Ф. | ПИНб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Векшин Г. Ф. | ПИНб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 0 до 8.                          *");
            Console.WriteLine("* Подсчитать сумму четных элементов массива.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int arrayLength = 10;
            int[] array = new int[arrayLength];

            Console.WriteLine("Введите " + arrayLength + " элементов массива (от 0 до 8):");
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("array[" + i + "] = ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Массив: { ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1) Console.Write(", ");
            }
            Console.WriteLine(" }");

            int result = ds.Calculate(array);
            Console.WriteLine("Сумма четных элементов = " + result);

            Console.ReadLine();
        }
    }
}

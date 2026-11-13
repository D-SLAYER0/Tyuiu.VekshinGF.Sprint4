using Tyuiu.VekshinGF.Sprint4.Task6.V15.Lib;
namespace Tyuiu.VekshinGF.Sprint4.Task6.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Векшин Г. Ф. | ПИНб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Строковые массивы (класс Array)                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Векшин Г. Ф. | ПИНб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных:                                            *");
            Console.WriteLine("* [\"Чикаго\", \"Хьюстон\", \"Феникс\", \"Филадельфия\", \"Сан-Антонио\", \"Сан-Диего\", \"Даллас\"] *");
            Console.WriteLine("* Используя класс Array подсчитайте количество элементов, длина которых   *");
            Console.WriteLine("* меньше 7.                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] array = { "Чикаго", "Хьюстон", "Феникс", "Филадельфия", "Сан-Антонио", "Сан-Диего", "Даллас" };

            Console.Write("Массив: { ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("\"" + array[i] + "\"");
                if (i < array.Length - 1) Console.Write(", ");
            }
            Console.WriteLine(" }");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.Calculate(array);
            Console.WriteLine("Количество элементов с длиной < 7 = " + result);

            Console.ReadLine();
        }
    }
}

using Tyuiu.VekshinGF.Sprint4.Task4.V16.Lib;
namespace Tyuiu.VekshinGF.Sprint4.Task4.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix = {
                { 4, 6, 4, 6, 4 },
                { 6, 4, 6, 4, 6 },
                { 4, 6, 4, 6, 4 },
                { 6, 4, 6, 4, 6 },
                { 4, 6, 4, 6, 4 }
            };

            int[,] result = ds.Calculate(matrix);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Assert.AreEqual(1, result[i, j]);
                }
            }
        }

        [TestMethod]
        public void Calculate_AllOdd_ReturnsSame()
        {
            DataService ds = new DataService();
            int[,] matrix = {
                { 3, 5, 7, 3, 5 },
                { 7, 3, 5, 7, 3 },
                { 5, 7, 3, 5, 7 },
                { 3, 5, 7, 3, 5 },
                { 7, 3, 5, 7, 3 }
            };

            int[,] result = ds.Calculate(matrix);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Assert.AreEqual(matrix[i, j], result[i, j]);
                }
            }
        }
    }
}

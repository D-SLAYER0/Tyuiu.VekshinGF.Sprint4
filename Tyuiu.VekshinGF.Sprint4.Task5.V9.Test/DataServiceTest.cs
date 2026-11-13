using Tyuiu.VekshinGF.Sprint4.Task5.V9.Lib;
namespace Tyuiu.VekshinGF.Sprint4.Task5.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix = {
                { -4, -2, 0, 2, 4 },
                { -3, -1, 1, 3, -4 },
                { 0, 0, 0, 0, 0 },
                { 1, 2, 3, 4, -1 },
                { -4, -3, -2, -1, 0 }
            };
            // Положительные: 2, 4, 1, 3, 1, 2, 3, 4 = 8
            int expected = 8;

            int result = ds.Calculate(matrix);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetCountPositiveEl_AllPositive_Returns25()
        {
            DataService ds = new DataService();
            int[,] matrix = {
                { 1, 2, 3, 4, 1 },
                { 2, 3, 4, 1, 2 },
                { 3, 4, 1, 2, 3 },
                { 4, 1, 2, 3, 4 },
                { 1, 2, 3, 4, 1 }
            };
            int expected = 25;

            int result = ds.Calculate(matrix);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetCountPositiveEl_AllNonPositive_Returns0()
        {
            DataService ds = new DataService();
            int[,] matrix = {
                { -4, -3, -2, -1, 0 },
                { -4, -3, -2, -1, 0 },
                { -4, -3, -2, -1, 0 },
                { -4, -3, -2, -1, 0 },
                { -4, -3, -2, -1, 0 }
            };
            int expected = 0;

            int result = ds.Calculate(matrix);

            Assert.AreEqual(expected, result);
        }
    }
}

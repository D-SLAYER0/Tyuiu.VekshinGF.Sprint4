using Tyuiu.VekshinGF.Sprint4.Task3.V12.Lib;
namespace Tyuiu.VekshinGF.Sprint4.Task3.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = {
                { 9, 7, 4, 9, 7 },
                { 5, 2, 5, 7, 6 },
                { 8, 3, 3, 5, 7 },
                { 8, 4, 2, 4, 5 },
                { 8, 8, 9, 5, 6 }
            };
            int expected = 2;

            int result = ds.Calculate(array);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetMinElThirdColumn_AllSame_ReturnsSameValue()
        {
            DataService ds = new DataService();
            int[,] array = {
                { 1, 1, 5, 1, 1 },
                { 1, 1, 5, 1, 1 },
                { 1, 1, 5, 1, 1 },
                { 1, 1, 5, 1, 1 },
                { 1, 1, 5, 1, 1 }
            };
            int expected = 5;

            int result = ds.Calculate(array);

            Assert.AreEqual(expected, result);
        }
    }
}

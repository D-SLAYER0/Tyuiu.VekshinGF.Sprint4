using Tyuiu.VekshinGF.Sprint4.Task2.V27.Lib;
namespace Tyuiu.VekshinGF.Sprint4.Task2.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 2, 3, 4, 5, 6, 7, 2, 3, 4, 5, 6, 7, 2 };
            // Чётные: 2, 4, 6, 2, 4, 6, 2 = 26
            int expected = 26;

            int result = ds.Calculate(array);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetSumEvenArrEl_AllOdd_Returns0()
        {
            DataService ds = new DataService();
            int[] array = { 3, 5, 7, 3, 5, 7, 3, 5, 7, 3, 5, 7, 3 };
            int expected = 0;

            int result = ds.Calculate(array);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetSumEvenArrEl_AllEven_ReturnsSum()
        {
            DataService ds = new DataService();
            int[] array = { 2, 4, 6, 2, 4, 6, 2, 4, 6, 2, 4, 6, 2 };
            // 2+4+6+2+4+6+2+4+6+2+4+6+2 = 50
            int expected = 50;

            int result = ds.Calculate(array);

            Assert.AreEqual(expected, result);
        }
    }
}

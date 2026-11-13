using Tyuiu.VekshinGF.Sprint4.Task1.V13.Lib;
namespace Tyuiu.VekshinGF.Sprint4.Task1.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 8, 1, 5, 4, 2, 1, 2, 7, 6, 1 };
            int expected = 22;

            int result = ds.Calculate(array);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetSumEvenArrEl_AllOdd_Returns0()
        {
            DataService ds = new DataService();
            int[] array = { 1, 3, 5, 7, 9, 1, 3, 5, 7, 9 };
            int expected = 0;

            int result = ds.Calculate(array);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetSumEvenArrEl_AllEven_ReturnsSum()
        {
            DataService ds = new DataService();
            int[] array = { 2, 4, 6, 8, 0, 2, 4, 6, 8, 0 };
            int expected = 40;

            int result = ds.Calculate(array);

            Assert.AreEqual(expected, result);
        }
    }
 }


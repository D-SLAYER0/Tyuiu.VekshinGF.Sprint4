using Tyuiu.VekshinGF.Sprint4.Task0.V29.Lib;
namespace Tyuiu.VekshinGF.Sprint4.Task0.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };
            int expected = 32;

            int result = ds.GetSumOddArrEl(array);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetSumOddArrEl_AllEven_Returns0()
        {
            DataService ds = new DataService();
            int[] array = { 2, 4, 6, 8, 0 };
            int expected = 0;

            int result = ds.GetSumOddArrEl(array);

            Assert.AreEqual(expected, result);
        }
    }
    }
}

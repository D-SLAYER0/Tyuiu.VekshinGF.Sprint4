using Tyuiu.VekshinGF.Sprint4.Task7.V3.Lib;

namespace Tyuiu.VekshinGF.Sprint4.Task7.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int n = 4;
            int m = 2;
            string value = "27182818";
            int expected = 3;

            int result = ds.Calculate(n, m, value);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Calculate_2x4_AllOdd_Returns8()
        {
            DataService ds = new DataService();
            int n = 2;
            int m = 4;
            string value = "13579135";
            int expected = 8;

            int result = ds.Calculate(n, m, value);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Calculate_4x2_AllEven_Returns0()
        {
            DataService ds = new DataService();
            int n = 4;
            int m = 2;
            string value = "24680246";
            int expected = 0;

            int result = ds.Calculate(n, m, value);

            Assert.AreEqual(expected, result);
        }
    }
}

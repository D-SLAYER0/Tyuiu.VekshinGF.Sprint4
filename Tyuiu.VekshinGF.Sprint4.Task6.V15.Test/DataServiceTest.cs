using Tyuiu.VekshinGF.Sprint4.Task6.V15.Lib;

namespace Tyuiu.VekshinGF.Sprint4.Task6.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] array = { "Чикаго", "Хьюстон", "Феникс", "Филадельфия", "Сан-Антонио", "Сан-Диего", "Даллас" };
            int expected = 3;

            int result = ds.Calculate(array);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Calculate_AllShort_ReturnsAll()
        {
            DataService ds = new DataService();
            string[] array = { "А", "БВ", "ГДЕ", "ЖЗИК" };
            int expected = 4;

            int result = ds.Calculate(array);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Calculate_AllLong_Returns0()
        {
            DataService ds = new DataService();
            string[] array = { "Филадельфия", "Сан-Антонио", "Сан-Диего" };
            int expected = 0;

            int result = ds.Calculate(array);

            Assert.AreEqual(expected, result);
        }
    }
}

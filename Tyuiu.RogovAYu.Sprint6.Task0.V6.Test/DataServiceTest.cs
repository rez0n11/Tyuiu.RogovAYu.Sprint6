using Tyuiu.RogovAYu.Sprint6.Task0.V6.Lib;
namespace Tyuiu.RogovAYu.Sprint6.Task0.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual(0.707,ds.Calculate(1));
        }
    }
}

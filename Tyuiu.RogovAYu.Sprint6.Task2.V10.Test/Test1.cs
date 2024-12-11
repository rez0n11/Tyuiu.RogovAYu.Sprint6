using Tyuiu.RogovAYu.Sprint6.Task2.V10.Lib;
namespace Tyuiu.RogovAYu.Sprint6.Task2.V10.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            double[] doubles = { };
            CollectionAssert.AreEqual(doubles, ds.GetMassFunction(-5, 5));
        }
    }
}

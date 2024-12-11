using Tyuiu.RogovAYu.Sprint6.Task4.V30.Lib;
namespace Tyuiu.RogovAYu.Sprint6.Task4.V30.Test
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

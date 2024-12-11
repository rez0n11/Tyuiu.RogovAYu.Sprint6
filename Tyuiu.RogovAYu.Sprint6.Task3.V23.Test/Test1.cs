using Tyuiu.RogovAYu.Sprint6.Task3.V23.Lib;
namespace Tyuiu.RogovAYu.Sprint6.Task3.V23.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            int[] ints = { -19, -16, -9, 13, 20 };
            int[] ints2 = new int[5];
            int[,] input = { { 0, -19, 25, 34, 0 }, { -19, -16, 1, -5, 34 }, { 1, 13, -5, -17, -5 }, { 3, -9, -15, -1, 0 }, { 1, 20, 15, -5, 31 } };
            int[,] dss = ds.Calculate(input);
            for (int i=0;i<5;i++) { ints2[i] = dss[i, 1]; }
            CollectionAssert.AreEqual(ints,ints2);
        }
    }
}

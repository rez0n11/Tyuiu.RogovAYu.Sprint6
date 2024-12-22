using System.IO;
using System.Numerics;
using Tyuiu.RogovAYu.Sprint6.Task7.V27.Lib;
namespace Tyuiu.RogovAYu.Sprint6.Task7.V27.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            string path = Path.Combine("C:", "DataSprint6", "huh.txt");

            int[,] m = { { 1, 2},{2, 0},{3, 3},{ -2, 5},{ -1, 24 },{ 12413254, 32432234} };

            CollectionAssert.AreEqual(m, ds.GetMatrix(path));
        }
    }
}

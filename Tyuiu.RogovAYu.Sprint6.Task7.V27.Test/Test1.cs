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
            Assert.AreEqual(-1, ds.GetMatrix(Path.Combine("C:", "DataSprint6", "InPutDataFileTask7V27.csv"))[4,4]);
        }
    }
}

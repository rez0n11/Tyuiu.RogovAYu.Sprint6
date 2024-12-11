using Tyuiu.RogovAYu.Sprint6.Task6.V14.Lib;
namespace Tyuiu.RogovAYu.Sprint6.Task6.V14.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            Assert.AreEqual("GzTsc AucHJjziZ jiUFMDjMsEervIz ziwVyU", ds.CollectTextFromFile(Path.Combine("C:", "DataSprint6", "InPutDataFileTask6V14.txt")));
        }
    }
}

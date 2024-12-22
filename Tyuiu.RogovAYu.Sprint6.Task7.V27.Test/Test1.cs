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
            string path = Path.Combine("C:", "DataSprint6", "InPutDataFileTask7V27.csv");

            string[] file = File.ReadAllText(path).Split('\n');
            
            int[,] m = new int[file.Length, file[0].Split(';').Length];

            for (int i = 0; i < file.Length; i++)
            {
                for (int j = 0; j < file[i].Split(';').Length; j++)
                {
                    m[i, j] = Convert.ToInt32(file[i].Split(';')[j]);
                    if (m[4, j] < 0) { m[4, i] = -1; }
                }
                
            }
            
            CollectionAssert.AreEqual(m, ds.GetMatrix(path));
        }
    }
}

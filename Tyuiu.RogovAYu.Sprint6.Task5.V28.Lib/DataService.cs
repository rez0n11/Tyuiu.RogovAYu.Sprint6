using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.RogovAYu.Sprint6.Task5.V28.Lib
{
    public class DataService : ISprint6Task5V28
    {
        public double[] LoadFromDataFile(string path)
        {
            string[] data = File.ReadAllLines(path);
            double[] input = new double[data.Length];
            double[] output = new double[0];
            for (int i=0;i<data.Length;i++) {input[i] = double.Parse(data[i]); }
            output = input.Where(val => val < 10).ToArray(); ;
            return output;
        }
    }
}

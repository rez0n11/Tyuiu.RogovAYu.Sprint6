using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.RogovAYu.Sprint6.Task2.V10.Lib
{
    public class DataService : ISprint6Task2V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result = new double[stopValue - startValue + 1];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = F(i + startValue);
            }
            return result;
        }

        public double F(int x) { return Math.Round((2 * x - 1) / (Math.Sin(x) +1) + 2 * x - 4, 3); }
    }
}

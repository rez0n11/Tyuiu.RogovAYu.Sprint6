using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.RogovAYu.Sprint6.Task4.V30.Lib
{
    public class DataService : ISprint6Task4V30
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
        public double F(int x) { return Math.Round((5 * x + 2.5) / (Math.Sin(x) + 2) + 2 * x + 2, 3); }

    }
}

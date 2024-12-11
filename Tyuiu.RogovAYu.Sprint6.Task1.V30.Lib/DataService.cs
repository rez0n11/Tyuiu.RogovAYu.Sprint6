using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.RogovAYu.Sprint6.Task1.V30.Lib
{
    public class DataService : ISprint6Task1V30
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result = new double[stopValue-startValue+1];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = F(i+startValue);
            }
            return result; 
        }

        public double F(int x) { return Math.Round((2 * x - 3) / (Math.Cos(x) - 2 * x) + 5 * x - 6, 2); }
    }
}

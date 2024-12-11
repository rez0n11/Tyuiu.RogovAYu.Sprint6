using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.RogovAYu.Sprint6.Task0.V6.Lib
{
    public class DataService : ISprint6Task0V6
    {
        public double Calculate(int x)
        {
            return Math.Round(x/Math.Sqrt(x+x*x),3);
        }
    }
}

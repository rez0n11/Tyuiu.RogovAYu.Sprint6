using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.RogovAYu.Sprint6.Task3.V23.Lib
{
    public class DataService : ISprint6Task3V23
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[,] a = matrix;
           for (int i = 0; i < a.GetLength(0)-1; i++)
            { 
                    if (a[i,1] > a[i+1,1])
                    {
                        int c = a[i,1];
                        a[i,1] = a[i+1,1];
                        a[i+1,1] = c;
                    }
            }
           return a;
        }
    }
}

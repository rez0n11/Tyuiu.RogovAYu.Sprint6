using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.RogovAYu.Sprint6.Task7.V27.Lib
{
    public class DataService : ISprint6Task7V27
    {
        public int[,] GetMatrix(string path)
        {
            string file = File.ReadAllText(path);
            string[] rows = file.Split('\n');
            foreach (string row in rows) {row.Trim(); }
            int rc = rows.Length, cc = rows[0].Split(';').Length;
            int[,] matrix = new int[rc,cc];
            for (int i = 0; i < rc; i++)
            {
                for (int j = 0; j < cc; j++) 
                {
                    matrix[i, j] = Convert.ToInt32(rows[i].Split(';')[j]);
                    if (i == 4 && matrix[i, j] < 0) { matrix[i, j] = -1; }
                }
            }

            return matrix;
        }
    }
}

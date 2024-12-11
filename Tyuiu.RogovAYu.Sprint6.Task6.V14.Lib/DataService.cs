using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.RogovAYu.Sprint6.Task6.V14.Lib
{
    public class DataService : ISprint6Task6V14
    {
        public string CollectTextFromFile(string path)
        {
            string[] s = File.ReadAllText(path).Split(' ','\n');
            string[] a = new string[s.Length];
            int i = 0;
            foreach (string s2 in s) { if (s[i].Contains('z')) { a[i] = s2.Trim(); };i++; }
            string res = string.Join(" ", a);   
            for (i = 0; i < res.Length-1; i++) 
            {
                if (res[i] == res[i+1]&& res[i]==' ')
                {
                  res= res.Remove(i,1);i--;
                }

            }
            return res.Trim();
            
           
        }
    }
}

using Tyuiu.RogovAYu.Sprint6.Task3.V23.Lib;
namespace Tyuiu.RogovAYu.Sprint6.Task3.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void GoButton_RAYu_Click(object sender, EventArgs e)
        {
            DataService ds = new();
            int[,] input = { { 0, -19, 25, 34, 0 }, { -19, -16, 1, -5, 34 }, { 1, 13, -5, -17, -5 }, { 3, -9, -15, -1, 0 }, { 1, 20, 15, -5, 31 } };
            int[,] dsr = ds.Calculate(input);
            for (int i = 0; i < 5; i++)
            {
                GridRes_RAYu.Rows.Add(dsr[i, 0], dsr[i, 1], dsr[i, 2], dsr[i, 3], dsr[i, 4]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void HelpButton_RAYu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил Рогов Александр Юрьевич, ПКТб-24-1", "Сообщение");
        }
    }
}

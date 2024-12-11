using Tyuiu.RogovAYu.Sprint6.Task2.V10.Lib;
namespace Tyuiu.RogovAYu.Sprint6.Task2.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }



        private void GoButton_RAYu_Click(object sender, EventArgs e)
        {
            try 
            {
                DataService ds = new();
                double[] res = ds.GetMassFunction(int.Parse(TextStart_RAYu.Text), int.Parse(TextStop_RAYu.Text));
                for (int i = 0; i < res.Length; i++)
                {
                    dataGridView1.Rows.Add(int.Parse(TextStart_RAYu.Text)+i,res[i]);
                }
            }
            catch { MessageBox.Show("Неверные данные", "Ошибка"); }
        }

        private void HelpButton_RAYu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил Рогов Александр Юрьевич, ПКТб-24-1","Сообщение");
        }
    }
}

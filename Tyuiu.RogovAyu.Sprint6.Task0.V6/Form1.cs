using Tyuiu.RogovAYu.Sprint6.Task0.V6.Lib;
namespace Tyuiu.RogovAYu.Sprint6.Task0.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

       

        private void ButtonDo_RAYu_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new();
                TextOut_RAYu.Text = Convert.ToString(ds.Calculate(int.Parse(TextIn_RAYu.Text)));
            }
            catch { MessageBox.Show("Неверные данные"); }
        }

        private void ButtonHelp_RAYu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил Рогов Александр Юревич, ПКТб-24-1");
        }
    }
}

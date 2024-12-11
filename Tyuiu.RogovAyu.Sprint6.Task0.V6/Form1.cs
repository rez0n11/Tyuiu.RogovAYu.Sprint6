using Tyuiu.RogovAYu.Sprint6.Task0.V6.Lib;
namespace Tyuiu.RogovAyu.Sprint6.Task0.V6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { DataService ds = new();
                TextOut_RAYu.Text = Convert.ToString(ds.Calculate(int.Parse(TextIn_RAYu.Text)));}
            catch { MessageBox.Show("Неверные данные"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил Рогов Александр Юрьевич, ПКТб-24-1","Сообщение");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void GroupTask_RAYu_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using Tyuiu.RogovAYu.Sprint6.Task1.V30.Lib;
namespace Tyuiu.RogovAYu.Sprint6.Task1.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void LabelStart_RaYu_Click(object sender, EventArgs e)
        {

        }

        private void GoButton_RAYu_Click(object sender, EventArgs e)
        {
            try
            {
                DataService ds = new();
                double[] result = ds.GetMassFunction(int.Parse(TextStart_RAYu.Text), int.Parse(TextStop_RAYu.Text));
                TextOut_RAYu.AppendText("+---------------+" + Environment.NewLine);
                TextOut_RAYu.AppendText("|   X   |  F(x) |" + Environment.NewLine);
                TextOut_RAYu.AppendText("+---------------+" + Environment.NewLine);
                for (int i = 0; i < result.Length; i++) { string s = string.Format("|{0,5:d}  | {1,5:f2} |", i + int.Parse(TextStart_RAYu.Text), result[i]);
                    TextOut_RAYu.AppendText(s + Environment.NewLine);
                }
                TextOut_RAYu.AppendText("+---------------+\n");
            }
            catch { MessageBox.Show("Неверные данные"); }
        }
    }
}

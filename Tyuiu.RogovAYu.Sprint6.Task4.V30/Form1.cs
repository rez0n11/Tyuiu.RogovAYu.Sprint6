using Tyuiu.RogovAYu.Sprint6.Task4.V30.Lib;
namespace Tyuiu.RogovAYu.Sprint6.Task4.V30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string s = Path.GetTempFileName();
            File.WriteAllText(s, textRes.Text);

            DialogResult = MessageBox.Show("Файл Сохранен. \nОткрыть?","Сообщение",MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process txt = new();
                txt.StartInfo.FileName = "notepad.exe";
                txt.StartInfo.Arguments = s;
                txt.Start();

            }
        }

        private void Helpbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил Рогов Александр Юрьевич, ПКТб-24-1","Сообщение");
        }

        
        private void GoButton_Click(object sender, EventArgs e)
        {
            
            DataService ds = new();
            double[] res= ds.GetMassFunction(int.Parse(textBoxStart.Text),int.Parse(textBoxStop.Text));
            chartFx.Series[0].Points.Clear();
            for (int i = 0; i < res.Length; i++)
            {
                chartFx.Series[0].Points.AddXY(int.Parse(textBoxStart.Text)+i, res[i]);
                textRes.AppendText(res[i]+Environment.NewLine);
            }
            ;
        }
    }
}

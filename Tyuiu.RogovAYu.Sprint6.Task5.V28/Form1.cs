using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;
using Tyuiu.RogovAYu.Sprint6.Task5.V28.Lib;
namespace Tyuiu.RogovAYu.Sprint6.Task5.V28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {

        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            DataService ds = new();
            int i = 0;
            double[] r = ds.LoadFromDataFile(Path.Combine("C:", "DataSprint6", "InPutDataFileTask5V28.txt"));
            foreach (double d in r) {
                GridBox.Rows.Add(i,d);i++;
                chart.Series[0].Points.AddXY(i,d);
            }
        }
    }
}

using System.IO;
using Tyuiu.RogovAYu.Sprint6.Task6.V14;
using Tyuiu.RogovAYu.Sprint6.Task7.V27.Lib;
namespace Tyuiu.RogovAYu.Sprint6.Task7.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            buttonGo.Enabled = false;
            buttonSave.Enabled = false;

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            
            openFileDialogTask.ShowDialog();
            string path = openFileDialogTask.FileName;
            string file = File.ReadAllText(path);
            string[] rows = file.Split('\n');
            int rc = rows.Length, cc = rows[0].Split(';').Length;
            int[,] input = new int[rc, cc];

            GridInput.ColumnCount = cc;
            GridOutput.ColumnCount = cc;
            GridInput.RowCount = rc;
            GridOutput.RowCount = rc;

            

            for (int i = 0; i < rc; i++)
            {
                for (int j = 0; j < cc; j++)
                {
                    GridInput.Rows[i].Cells[j].Value = Convert.ToInt32(rows[i].Split(';')[j]);
                }
            }

            buttonSave.Enabled = true;
            buttonGo.Enabled = true;
        }



        private void buttonSave_Click(object sender, EventArgs e)
        {
            int[,] outp = new int[GridOutput.RowCount, GridInput.ColumnCount];
            for (int i = 0; i<GridOutput.RowCount; i++)
            {
                for (int j = 0;j < GridOutput.ColumnCount; j++)
                {
                    outp[i, j] = Convert.ToInt32(GridOutput.Rows[i].Cells[j].Value.ToString());
                }
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            DataService ds = new();

            string path = openFileDialogTask.FileName;
            string file = File.ReadAllText(path);
            string[] rows = file.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            int rc = rows.Length, cc = rows[0].Split(';').Length;   
            int[,] output = ds.GetMatrix(path);
            for (int i = 0; i < rc; i++)
            {
                for (int j = 0; j < cc; j++)
                {
                    GridOutput.Rows[i].Cells[j].Value = output[i,j];
                }
            }
        }


       

    }
}

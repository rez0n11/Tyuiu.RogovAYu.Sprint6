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
            toolTipButton.SetToolTip(buttonHelp, "О программе");
            toolTipButton.SetToolTip(buttonSave, "Сохранить в файл");
            toolTipButton.SetToolTip(buttonLoad, "Загрузить файл");
            toolTipButton.SetToolTip(buttonGo, "Выполнить");
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


            buttonGo.Enabled = true;
        }



        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "OutPutFileTask7.csv";
            saveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog.ShowDialog();
            string path = saveFileDialog.FileName;
            string str = "";
            if (new FileInfo(path).Exists) { File.Delete(path); }

            string[,] outp = new string[GridOutput.RowCount, GridInput.ColumnCount];
            for (int i = 0; i < GridOutput.RowCount; i++)
            {
                for (int j = 0; j < GridOutput.ColumnCount; j++)
                {
                    if (j != GridOutput.ColumnCount - 1)
                    {
                        str += GridOutput.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += GridOutput.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine); str = "";
            }



        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout about = new();
            about.ShowDialog();
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
                    GridOutput.Rows[i].Cells[j].Value = output[i, j];
                }
            }
            buttonSave.Enabled = true;
        }

        private void Mouse_Load(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Загрузить";
        }

        private void Mouse_Save(object sender, MouseEventArgs e)
        {
            toolTipButton.ToolTipTitle = "Сохранить";
        }

        private void MouseGo(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Выполнить";
        }

        private void MouseInfo(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Справка";
        }

        private void toolTipButton_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}

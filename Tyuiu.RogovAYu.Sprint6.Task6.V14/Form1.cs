using Tyuiu.RogovAYu.Sprint6.Task6.V14.Lib;
namespace Tyuiu.RogovAYu.Sprint6.Task6.V14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string path;

        private void FIleButton_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            path = openFileDialogTask.FileName;
            textBoxInput.Text = File.ReadAllText(path);


        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            FormAbout fa = new();
            fa.ShowDialog();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            textBoxOutput.Text = ds.CollectTextFromFile(path);
        }
    }
}

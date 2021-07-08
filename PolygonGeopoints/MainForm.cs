using System;
using System.ComponentModel;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.IO;



namespace PolygonGeopoints
{
    public partial class MainForm : Form
    {
        private dynamic recievedData;
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string result = UserService.RequestPolygon(textBoxSearch.Text);

            MessageBox.Show("Точки полигона успешно получены");

            recievedData = ((dynamic)JToken.Parse(result))[0].geojson.coordinates;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            savePointsToFileDialog.DefaultExt = "json";
            savePointsToFileDialog.Filter = "Json files (*.json)|*.json|All files (*.*)|*.*";
            savePointsToFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            savePointsToFileDialog.ShowDialog();
        }

        private void savePointsToFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            
            File.WriteAllText(Path.GetFullPath(savePointsToFileDialog.FileName), recievedData.ToString());
        }
    }
}

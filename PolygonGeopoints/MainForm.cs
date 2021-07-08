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
            try
            {
                MessageBox.Show("Точки полигона успешно получены для географического объекта \"" + (dynamic)((dynamic)JToken.Parse(result)[0]).display_name + "\"");
                recievedData = ((dynamic)JToken.Parse(result))[0].geojson.coordinates;
            }
            catch (Exception)
            {
                MessageBox.Show("Введите корректное название географического объекта", "Невозможно найти объект", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (recievedData == default(dynamic))
            {
                MessageBox.Show("Сначала введите название объекта и нажмите кнопку \"Найти\"", "Невозможно сохранить полигон", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            savePointsToFileDialog.DefaultExt = "json";
            savePointsToFileDialog.Filter = "Json files (*.json)|*.json|All files (*.*)|*.*";
            savePointsToFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            savePointsToFileDialog.FileName = "PolygonCoordinates";
            savePointsToFileDialog.ShowDialog();
        }

        private void savePointsToFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string result;
            try
            {
                result = calculateNewPolygon().ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Что-то пошло не так в процессе обработки результата для сохранения в файл", "Ошибка");
                return;
            }
            try
            {
                File.WriteAllText(Path.GetFullPath(savePointsToFileDialog.FileName), result);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Невозможно сохранить файл");
                return;
            }
            MessageBox.Show("Файл успешно сохранен");
        }

        private JArray calculateNewPolygon()
        {
            int period = Decimal.ToInt32(numericUpDownPeriod.Value);
            JArray result = new JArray();
            JArray areas = JArray.Parse(((JToken)(recievedData)).ToString());
            foreach (var area in areas)
            {
                JArray points;
                if (JArray.Parse(area.ToString()).Count == 1)
                {
                    points = JArray.Parse(JArray.Parse(area.ToString())[0].ToString());

                }
                else
                {
                    points = JArray.Parse(area.ToString());
                }

                int i = 1;
                for (int j = 0; j < points.Count; j++)
                {
                    if ((i % period) != 0)
                    {
                        points[j].Remove(); j--;
                    }
                    i++;
                }
                if (JArray.Parse(area.ToString()).Count == 1)
                {
                    JArray tmp = new JArray
                    {
                        points
                    };
                    result.Add(tmp);
                }
                else
                {
                    result.Add(points);
                }
            }
            return result;
        }
    }
}

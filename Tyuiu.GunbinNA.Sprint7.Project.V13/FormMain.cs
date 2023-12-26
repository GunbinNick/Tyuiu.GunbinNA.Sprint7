using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GunbinNA.Sprint7.Project.V13.Lib;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace Tyuiu.GunbinNA.Sprint7.Project.V13
{
    public partial class FormMain_GNA : Form
    {
        WMPLib.WindowsMediaPlayer music = new WMPLib.WindowsMediaPlayer();
        bool isPlaying = false;
        bool button = false;
        public FormMain_GNA()
        {
            InitializeComponent();
            music.URL = @"C:\Users\wackko\source\repos\Tyuiu.GunbinNA.Sprint7\Music and massive\ListSongs.mp3";
            music.settings.volume = 10;
            music.controls.play();

            openFileDialogTask_GNA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_GNA.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static string path;
        static int columns;
        DataService ds = new DataService();
        public static string[,] LoadFromFileData(string path)
        {
            string filedata = File.ReadAllText(path);
            filedata = filedata.Replace('\n', '\r');
            string[] lines = filedata.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            string[,] array = new string[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_str = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = line_str[j];
                }
            }
            return array;
        }
        
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormHelp_GNA help = new FormHelp_GNA();
            help.ShowDialog();
        }

        private void buttonNotes_Click(object sender, EventArgs e)
        {
            try
            {
                buttonAdd_GNA.Visible = false;
                buttonDelete_GNA.Visible = false;
                textBoxCapital_GNA.Visible = false;
                textBoxCountry_GNA.Visible = false;
                textBoxDel_GNA.Visible = false;
                textBoxEcoClass_GNA.Visible = false;
                textBoxS_GNA.Visible = false;
                buttonDone_GNA.Visible = false;
                buttonChange_GNA.Visible = false;
                buttonSearch_GNA.Visible = false;
                buttonSort_GNA.Visible = false;
                textBoxSort_GNA.Visible = false;
                labelCapital_GNA.Visible = false;
                labelColumn_GNA.Visible = false;
                labelCountry_GNA.Visible = false;
                labelEcoClass_GNA.Visible = false;
                labelS_GNA.Visible = false;
                labelRow_GNA.Visible = false;
                labelSearch_GNA.Visible = false;
                textBoxSearch_GNA.Visible = false;
                dataGridViewFile_GNA.Visible = false;
                buttonLoadFile_GNA.Enabled = false;
                buttonSaveFile_GNA.Enabled = false;
                panelChoose_GNA.Visible = true;
                textBoxNotice_GNA.Visible = true;
                labelText_GNA.Visible = true;
            }
            catch
            {
                MessageBox.Show("Ошибка при открытии раздела", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            FormAbout_GNA form = new FormAbout_GNA();
            form.ShowDialog();
        }
        private void buttonLoadFile_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogTask_GNA.ShowDialog();
                path = openFileDialogTask_GNA.FileName;

                string[,] array = new string[rows, columns];

                array = LoadFromFileData(path);

                dataGridViewFile_GNA.ColumnCount = columns;
                dataGridViewFile_GNA.RowCount = rows;

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewFile_GNA.Columns[i].Width = 65;
                }
                dataGridViewFile_GNA.Columns[2].Width = 100;
                dataGridViewFile_GNA.Columns[3].Width = 95;
                dataGridViewFile_GNA.Columns[0].HeaderText = "Страна";
                dataGridViewFile_GNA.Columns[1].HeaderText = "Столица";
                dataGridViewFile_GNA.Columns[2].HeaderText = "Экон.Положение";
                dataGridViewFile_GNA.Columns[3].HeaderText = "Площадь терр.";

                buttonDone_GNA.Enabled = true;
                buttonSaveFile_GNA.Enabled = true;
                buttonChange_GNA.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Ошибка при открытии файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            addRow(textBoxCountry_GNA.Text, textBoxCapital_GNA.Text, textBoxEcoClass_GNA.Text, textBoxS_GNA.Text);
            try
            {
                int c = Convert.ToInt32(textBoxS_GNA.Text);
                addRow(textBoxCountry_GNA.Text, textBoxCapital_GNA.Text, textBoxEcoClass_GNA.Text, textBoxS_GNA.Text);
            }
            catch
            {
                MessageBox.Show("Введите корректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addRow(string textBoxCountry, string textBoxCapital, string textBoxEcoClass, string textBoxS)
        {
            try
            {
                String[] row = { textBoxCountry, textBoxCapital, textBoxEcoClass, textBoxS };
                dataGridViewFile_GNA.Rows.Add(row);
            }
            catch
            {
                MessageBox.Show("Введены не все данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogMatrix_GNA.FileName = "OutPutFileT.csv";
                saveFileDialogMatrix_GNA.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialogMatrix_GNA.ShowDialog();

                string path = saveFileDialogMatrix_GNA.FileName;
                FileInfo fileinfo = new FileInfo(path);
                bool fileex = fileinfo.Exists;

                if (fileex)
                    File.Delete(path);
                int rows = dataGridViewFile_GNA.RowCount;
                int columns = dataGridViewFile_GNA.ColumnCount;

                string str = "";
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (j != columns - 1)
                            str += dataGridViewFile_GNA.Rows[i].Cells[j].Value + ";";
                        else
                            str += dataGridViewFile_GNA.Rows[i].Cells[j].Value;
                    }
                    File.AppendAllText(path, str + Environment.NewLine);
                    str = "";
                }
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBoxSort_GNA.Text);
                int[] array = new int[rows];
                if ((n == 2) || (n == 3))
                {
                    MessageBox.Show("Данный столбец несортируем", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dataGridViewFile_GNA.Sort(dataGridViewFile_GNA.Columns[2], ListSortDirection.Descending);
            }
            catch
            {
                MessageBox.Show("Ошибка сортировки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (button)
            {
                buttonAdd_GNA.Visible = false;
                buttonDelete_GNA.Visible = false;
                textBoxCapital_GNA.Visible = false;
                textBoxCountry_GNA.Visible = false;
                textBoxDel_GNA.Visible = false;
                textBoxEcoClass_GNA.Visible = false;
                textBoxS_GNA.Visible = false;
                buttonDone_GNA.Enabled = true;
            }
            else
            {
                buttonAdd_GNA.Visible = true;
                buttonDelete_GNA.Visible = true;
                textBoxCapital_GNA.Visible = true;
                textBoxCountry_GNA.Visible = true;
                textBoxDel_GNA.Visible = true;
                textBoxEcoClass_GNA.Visible = true;
                textBoxS_GNA.Visible = true;
                buttonDone_GNA.Enabled = false;
            }
            button = !button;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridViewFile_GNA.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                string searchValue = textBoxSearch_GNA.Text;
                int num_col = Convert.ToInt32(textBoxSort_GNA.Text);
                foreach (DataGridViewRow row in dataGridViewFile_GNA.Rows)
                {
                    if (row.Cells[num_col].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка поиска. Возможно вы не ввели номер столбца", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                string[,] array = new string[rows, columns];

                array = LoadFromFileData(path);

                dataGridViewFile_GNA.ColumnCount = columns;
                dataGridViewFile_GNA.RowCount = rows;

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewFile_GNA.Columns[i].Width = 65;
                }
                dataGridViewFile_GNA.Columns[2].Width = 100;
                dataGridViewFile_GNA.Columns[3].Width = 95;
                dataGridViewFile_GNA.Columns[0].HeaderText = "Страна";
                dataGridViewFile_GNA.Columns[1].HeaderText = "Столица";
                dataGridViewFile_GNA.Columns[2].HeaderText = "Экон.Положение";
                dataGridViewFile_GNA.Columns[3].HeaderText = "Площадь терр.";
                for (int i = 0; i < dataGridViewFile_GNA.RowCount; i++)
                {
                    dataGridViewFile_GNA.Rows[i].HeaderCell.Value = i.ToString();
                }
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewFile_GNA.Rows[i].Cells[j].Value = array[i, j];
                    }
                }
                buttonSearch_GNA.Enabled = true;
                buttonSort_GNA.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Неполадки в обработке файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int row_index = Convert.ToInt32(textBoxDel_GNA.Text);
                dataGridViewFile_GNA.Rows.RemoveAt(row_index);
                dataGridViewFile_GNA.Refresh();
            }
            catch
            {
                MessageBox.Show("Вы пытаетесь удалить весь список или несуществующую строку. Не надо так делать.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMusic_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                music.controls.stop();
                buttonMusic_GNA.BackColor = Color.LimeGreen;
            }
            else
            {
                music.controls.play();
                buttonMusic_GNA.BackColor = Color.FromArgb(192, 255, 192);
            }

            isPlaying = !isPlaying;
        }

        private void comboBoxChoose_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBoxChoose_GNA.SelectedIndex == 0)
            {
                textBoxNotice_GNA.Text = "Россия - крупнейшее в мире государство, занимающее 1/8 часть суши и расположенное на северо-востоке Евразии. Россия — страна с многовековой историей, богатым культурным наследием и щедрой природой. В России можно найти почти всё то, что встречает путешественник по отдельности в той или иной стране — солнечные пляжи субтропиков и снежные горные вершины, бескрайние степи и глухие леса, бурные реки и тёплые моря.";
            }
            else if (comboBoxChoose_GNA.SelectedIndex == 1)
            {
                textBoxNotice_GNA.Text = "США - одно из крупнейших и влиятельнейших государств современного мира. Оно находится в Северной Америке и является четвертым по территории после России, Канады и Китая. Соединенные Штаты Америки – это многоликая и разнообразная страна, которая внесла весомый вклад в мировую культуру и науку. Она способна предложить путешественникам почти все, чем богат современный мир или природа: от чудес Гранд каньона, Великих озер, гор и тихоокеанского побережья до мегаполисов Нью-Йорка, Лас-Вегаса и Майами.";
            }
            else if (comboBoxChoose_GNA.SelectedIndex == 2)
            {
                textBoxNotice_GNA.Text = "Индия не место для труса. Представляя собой постоянный вызов для ума и тела, она основательно потрясает весь ваш организм. Она волнует, истощает и приводит в ярость. Вы скоро обнаружите, что это земля, где реалии повседневной жизни преобладают над тайнами популярного мифа. Вместо широко известного и часто неправильно понимаемого мистицизма древних религий Индия в действительности может предложить совсем другое чудо: богатство ее народов и ландшафтов";
            }
            else if (comboBoxChoose_GNA.SelectedIndex == 3)
            {
                textBoxNotice_GNA.Text = "Пакистан лежит в северо-западной части Южной Азии и граничит с Афганистаном, Индией, Ираном и Китаем, а также имеет прямой выход к побережью Аравийского моря. \n С туристической точки зрения Пакистан представляет собой неизведанную древнюю землю, где на протяжении многих тысячелетий постоянно сменялись цивилизации, культура и религия.Причем каждый район страны интересен по своему и имеет свои отличительные черты и уникальные достопримечательности, от национальных парков до древних руин.";
            }
            else if (comboBoxChoose_GNA.SelectedIndex == 4)
            {
                textBoxNotice_GNA.Text = "Нигер — крупнейшее государство Западной Африки (площадь 1 267 000 км²), в далеком прошлом — один из крупнейших очагов африканской культуры, входивший в состав древних государств Африки с VII по XVIII века. С начала XX века — владение Франции, с 1960 года — независимое государство. Официальный язык — французский. Большая часть страны расположена в крупнейшей пустыне мира Сахаре и представляет собой выровненное плато высотой 200-500 м над уровнем моря с возвышающимся в центральной части останцовым плато Аир (от 700–800 м в западной части до 1900 м в центре). На востоке плато круто обрывается к огромной песчаной пустыне Тенере (занимающей почти треть территории страны).";
            }
            else
            {
                MessageBox.Show("Примечания к такой стране нет.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonStats_Click(object sender, EventArgs e)
        {
            try
            {
                buttonAdd_GNA.Visible = false;
                buttonDelete_GNA.Visible = false;
                textBoxCapital_GNA.Visible = false;
                textBoxCountry_GNA.Visible = false;
                textBoxDel_GNA.Visible = false;
                textBoxEcoClass_GNA.Visible = false;
                textBoxS_GNA.Visible = false;
                buttonDone_GNA.Visible = true;
                buttonChange_GNA.Visible = true;
                buttonSearch_GNA.Visible = true;
                buttonSort_GNA.Visible = true;
                textBoxSort_GNA.Visible = true;
                labelCapital_GNA.Visible = true;
                labelColumn_GNA.Visible = true;
                labelCountry_GNA.Visible = true;
                labelEcoClass_GNA.Visible = true;
                labelS_GNA.Visible = true;
                labelRow_GNA.Visible = true;
                labelSearch_GNA.Visible = true;
                textBoxSearch_GNA.Visible = true;
                dataGridViewFile_GNA.Visible = true;
                buttonLoadFile_GNA.Enabled = true;
                buttonSaveFile_GNA.Enabled = false;
                panelChoose_GNA.Visible = false;
                textBoxNotice_GNA.Visible = false;
                labelText_GNA.Visible = false;
            }
            catch
            {
                MessageBox.Show("Ошибка при открытии раздела", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

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
    public partial class FormMain : Form
    {
        WMPLib.WindowsMediaPlayer music = new WMPLib.WindowsMediaPlayer();
        bool isPlaying = false;
        public FormMain()
        {
            InitializeComponent();
            music.URL = @"C:\Users\wackko\source\repos\Tyuiu.GunbinNA.Sprint7\Music and massive\ListSongs.mp3";
            music.settings.volume = 10;
            music.controls.play();

            openFileDialogTask.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
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
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                music.controls.stop();
                buttonMusic.BackColor = Color.LimeGreen;
            }
            else
            {
                music.controls.play();
                buttonMusic.BackColor = Color.FromArgb(192, 255, 192);
            }

            isPlaying = !isPlaying;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormHelp help = new FormHelp();
            help.ShowDialog();
        }

        private void buttonNotes_Click(object sender, EventArgs e)
        {

        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }
        private void buttonLoadFile_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogTask.ShowDialog();
                path = openFileDialogTask.FileName;

                string[,] array = new string[rows, columns];

                array = LoadFromFileData(path);

                dataGridView1.ColumnCount = columns;
                dataGridView1.RowCount = rows;

                for (int i = 0; i < columns; i++)
                {
                    dataGridView1.Columns[i].Width = 65;
                }
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[3].Width = 95;
                dataGridView1.Columns[0].HeaderText = "Страна";
                dataGridView1.Columns[1].HeaderText = "Столица";
                dataGridView1.Columns[2].HeaderText = "Экон.Положение";
                dataGridView1.Columns[3].HeaderText = "Площадь терр.";

                button1.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Ошибка при открытии файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string[,] array = new string[rows,columns];

                array = LoadFromFileData(path);

                dataGridView1.ColumnCount = columns;
                dataGridView1.RowCount = rows;

                for (int i = 0; i < columns; i++)
                {
                    dataGridView1.Columns[i].Width = 65;
                }
                dataGridView1.Columns[2].Width = 100;
                dataGridView1.Columns[3].Width = 95;
                dataGridView1.Columns[0].HeaderText = "Страна";
                dataGridView1.Columns[1].HeaderText = "Столица";
                dataGridView1.Columns[2].HeaderText = "Экон.Положение";
                dataGridView1.Columns[3].HeaderText = "Площадь терр.";
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].HeaderCell.Value = i.ToString();
                }
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = array[i, j];
                    }
                }
            }
            catch
            {
                MessageBox.Show("Неполадки в обработке файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                int c = Convert.ToInt32(textBoxS.Text);
                this.dataGridView1.Rows.Add(textBoxCountry.Text, textBoxCapital.Text, textBoxEcoClass.Text, textBoxS.Text);
            }
            catch
            {
                MessageBox.Show("Введите корректные данные", "Ошибка");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int row_index = Convert.ToInt32(textBoxDel.Text);
                dataGridView1.Rows.RemoveAt(row_index);
                dataGridView1.Refresh();
            }
            catch
            {
                MessageBox.Show("Вы пытаетесь удалить весь список или несуществующую строку. Не надо так делать.");
            }
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogMatrix.FileName = "OutPutFileT.csv";
                saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialogMatrix.ShowDialog();

                string path = saveFileDialogMatrix.FileName;
                FileInfo fileinfo = new FileInfo(path);
                bool fileex = fileinfo.Exists;

                if (fileex)
                    File.Delete(path);
                int rows = dataGridView1.RowCount;
                int columns = dataGridView1.ColumnCount;

                string str = "";
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (j != columns - 1)
                            str += dataGridView1.Rows[i].Cells[j].Value + ";";
                        else
                            str += dataGridView1.Rows[i].Cells[j].Value;
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
                int n = Convert.ToInt32(textBoxSort.Text);
                int[] array = new int[rows];
                if (n == 2)
                {
                    MessageBox.Show("Данный столбец несортируем", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (n == 3)
                {
                    for (int i = 0; i < rows; i++)
                    {
                        dataGridView1.Rows[i].Cells[3].Value = (dataGridView1.Rows[i].Cells[3].Value.ToString()).Replace(" ", string.Empty);
                        array[i] = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                    }
                    Array.Sort(array);
                    for (int i = 0; i < rows; i++)
                    {
                        dataGridView1.Rows[i].Cells[3].Value = array[i];
                    }
                }
                dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Descending);
            }
            catch
            {
                MessageBox.Show("Ошибка сортировки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                string searchValue = textBoxSearch.Text;
                int num_col = Convert.ToInt32(textBoxSort.Text);
                foreach (DataGridViewRow row in dataGridView1.Rows)
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
                music.URL = @"C:\Users\wackko\source\repos\Tyuiu.GunbinNA.Sprint7\Music and massive\ErrorSound.mp3";
                music.settings.volume = 25;
                music.controls.play();
                MessageBox.Show("Ошибка поиска. Возможно вы не ввели номер столбца", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                music.URL = @"C:\Users\wackko\source\repos\Tyuiu.GunbinNA.Sprint7\Music and massive\ListSongs.mp3";
                music.settings.volume = 10;
                music.controls.play();
            }
        }
    }
}

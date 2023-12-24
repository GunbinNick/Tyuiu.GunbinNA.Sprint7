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
            music.URL = @"C:\Users\wackko\source\repos\Tyuiu.GunbinNA.Sprint7\ListSongs.mp3";
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
                buttonMusic.BackColor = Color.Red;
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Users\wackko\source\repos\Tyuiu.GunbinNA.Sprint7\mass.csv";

                string[,] array = new string[rows,columns];

                array = LoadFromFileData(path);

                dataGridView1.ColumnCount = columns + 1;
                dataGridView1.RowCount = rows;

                for (int i = 0; i < columns; i++)
                {
                    dataGridView1.Columns[i].Width = 65;
                }
                dataGridView1.Columns[0].Width = 45;
                dataGridView1.Columns[3].Width = 100;
                dataGridView1.Columns[4].Width = 95;
                dataGridView1.Columns[0].HeaderText = "№ строки";
                dataGridView1.Columns[1].HeaderText = "Страна";
                dataGridView1.Columns[2].HeaderText = "Столица";
                dataGridView1.Columns[3].HeaderText = "Экон.Положение";
                dataGridView1.Columns[4].HeaderText = "Площадь терр.";
                int index = 0;
                for(int j = 0; j <= index; j++)
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = (i + index).ToString();
                    }
                int index_column = 1;
                int new_column = columns;
                while (index_column <= new_column)
                {
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            dataGridView1.Rows[i].Cells[index_column].Value = array[i, j];
                            index_column++;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("ОШИБКА");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                string str = textBoxS.Text;
                foreach (char c in str)
                {
                    if (c < '0' || c > '9')
                    { 
                        MessageBox.Show("Введите корректные данные", "Ошибка");
                        break;
                    }
                    else
                        this.dataGridView1.Rows.Add(textBoxCountry.Text, textBoxCapital.Text, textBoxEcoClass.Text, textBoxS.Text);
                }
            }
            catch
            {
                MessageBox.Show("Введите корректные данные", "Ошибка");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int row_index = Convert.ToInt32(textBoxDel.Text);
            dataGridView1.Rows.RemoveAt(row_index);
            dataGridView1.Refresh();
        }

        private void buttonLoadFile_Click(object sender, EventArgs e)
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
            dataGridView1.Columns[0].Width = 45;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 95;
            dataGridView1.Columns[0].HeaderText = "№ строки";
            dataGridView1.Columns[1].HeaderText = "Страна";
            dataGridView1.Columns[2].HeaderText = "Столица";
            dataGridView1.Columns[3].HeaderText = "Экон.Положение";
            dataGridView1.Columns[4].HeaderText = "Площадь терр.";

            for (int r = 0; r < rows; r++)
                for (int c = 0; c < columns; c++)
                    dataGridView1.Rows[r].Cells[c].Value = array[r, c];
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix.FileName = "OutPutFileTask7V1.csv";
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
    }
}

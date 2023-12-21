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
        }
        static int rows;
        static int columns;
        DataService ds = new DataService();
        public static int[,] LoadFromFileData(string path)
        {
            string filedata = File.ReadAllText(path);

            filedata = filedata.Replace('\n', '\r');
            string[] lines = filedata.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            using (TextFieldParser tfp = new TextFieldParser(path))
            {
                tfp.TextFieldType = FieldType.Delimited;
                tfp.SetDelimiters(";");

                while (!tfp.EndOfData)
                {
                    for (int i = 0; i < rows; i++)
                    {
                        string[] fields = tfp.ReadFields();
                        for (int j = 0; j < columns; j++)
                        {
                            array[i, j] = Convert.ToInt32(fields[j]);
                        }
                    }
                }
                return array;
            }


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
                string path = @"C:\Users\wackko\source\repos\Tyuiu.GunbinNA.Sprint7\mass1.csv";

                int[,] array = new int[rows, columns];

                array = LoadFromFileData(path);

                dataGridView1.ColumnCount = columns;
                dataGridView1.RowCount = rows;

                for (int i = 0; i < columns; i++)
                {
                    dataGridView1.Columns[i].Width = 50;
                }

                for(int j = 0; j < rows; j++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridView1.Rows[j].Cells[c].Value = array[j, c];
                    }
                }

            }
            catch
            {
                MessageBox.Show("ОШИБКА");
            }
        }
    }
}

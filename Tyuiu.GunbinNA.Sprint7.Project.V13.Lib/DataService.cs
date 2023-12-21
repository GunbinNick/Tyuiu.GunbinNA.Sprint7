using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.GunbinNA.Sprint7.Project.V13.Lib
{
    public class DataService
    {
        public string[,] GetTextFromFile(string path)
        {
            string filedata = File.ReadAllText(path);

            filedata = filedata.Replace('\n', '\r');
            string[] lines = filedata.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            string[,] array = new string[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = line_r[j];
                }
            }
            return array;
        }
    }
}

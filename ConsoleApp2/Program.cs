using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic.FileIO;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\wackko\source\repos\Tyuiu.GunbinNA.Sprint7\mass1.csv";

            var filedata = File.ReadAllText(path, Encoding.GetEncoding(1251));

            filedata = filedata.Replace("\n", "\r");
            string[] lines = filedata.Split(new string[] { "\r" }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < lines.Length; i++)
            {
                string[] line_str = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_str[j]);
                }

            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine(array[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}

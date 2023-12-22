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
        public int len = 0;
        public string[] GetTextFromFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                string[] line_len;
                while ((line = reader.ReadLine()) != null)
                {
                    line_len = line.Split(';');
                    len = line_len.Length;
                    continue;
                }
            }
            string[] array = new string[len];
            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    array[index] = line;
                    index++;
                }
            }
            return array;
        }
    }
}

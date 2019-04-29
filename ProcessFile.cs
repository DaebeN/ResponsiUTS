using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class ProcessFile
    {
        public static int size = 10;
        string path = @"D:\\Bayu Alif\project UTS\3\Program\data.txt";
        public string Name { get; set; }
        public ProcessFile(string name)
        {
            this.Name = name;
        }
        public ProcessFile()
        {

        }

        public void WriteFile()
        {
            for (int i = 0; i < size; i++)
            {
                string[] lines = { Name };
                File.WriteAllLines(path, lines);
            }
        }

        public bool ReadFile()
        {
            string[] lines;
            lines = File.ReadAllLines(path);
            for (int i = 0; i < size; i++)
            {
                this.Name = lines[i];
            }
            return true;
        }
    }
}

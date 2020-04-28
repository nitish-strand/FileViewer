using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileViewer_02
{
    class BackEndModel
    {
        private string _fp;
        public string FilePath {
            set
            {
                _fp = value;
                ReadFile();
            }
            get
            {
                return _fp;
            }
        }

        string _filepath = @"C:\Users\nitish\Desktop\demoData.txt";

        List<string> filelines = new List<string>();
        public List<string> FileLines
        {
            get
            {
                return filelines;
            }
        }

        
        public void ReadFile()
        {
            StreamReader file = new StreamReader(FilePath);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                filelines.Add(line);
            }
        }

        public BackEndModel()
        {
            FilePath = _filepath;
        }
    }
}

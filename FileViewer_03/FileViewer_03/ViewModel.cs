using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileViewer_03
{
    class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void On_PropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        private string _fp;
        public string FilePath
        {
            set
            {
                _fp = value;
                On_PropertyChanged("FilePath");
                ReadFile();
            }
            get
            {
                return _fp;
            }
        }

        string _filepath = @"C:\Users\nitish\Desktop\demoData.txt";

        //ObservableCollection<string> filelines = new ObservableCollection<string>();
        //public ObservableCollection<string> FileLines
        //{
        //    get
        //    {
        //        return filelines;
        //    }
        //}

        List<string> filelines;
        public List<string> FileLines
        {
            get
            {
                return filelines;
            }
            set
            {
                filelines = value;
                On_PropertyChanged("FileLines");
            }
        }


        public void ReadFile()
        {
            StreamReader file = new StreamReader(FilePath);
            string line;
            var resultlist = new List<string>();
            while ((line = file.ReadLine()) != null)
            {
                resultlist.Add(line);
            }
            FileLines = resultlist;
        }

        public ViewModel()
        {
            FilePath = _filepath;
        }
    }
}

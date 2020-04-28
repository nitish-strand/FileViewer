using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FileViewer_04
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
            }
            get
            {
                return _fp;
            }
        }

        //if want to set a default path.
        //string _filepath = @"C:\Users\nitish\Desktop\demoData.txt";

        ObservableCollection<string> filelines = new ObservableCollection<string>();
        public ObservableCollection<string> FileLines
        {
            get
            {
                return filelines;
            }
            set
            {
                filelines = value;
            }
        }

        public ICommand MyCommand { get; set; }

        public ViewModel()
        {
            MyCommand = new Command(ReadFile);
        }

        private void ReadFile(object parameters)
        {
            StreamReader file = new StreamReader(FilePath);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                filelines.Add(line);
            }
        }

    }
}
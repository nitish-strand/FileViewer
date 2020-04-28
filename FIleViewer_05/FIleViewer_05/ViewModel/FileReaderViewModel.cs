using FIleViewer_05.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FIleViewer_05.ViewModel
{
    public class FileReaderViewModel
    {

        public ICommand MyCommand { get; set; }
        public ICommand SubmitChanges { get; set; }
        public FileReaderViewModel()
        {
            MyCommand = new Command.Command(ReadFile);
            SubmitChanges = new Command.Command(WriteFile);
        }

        private ObservableCollection<FileReaderModel> _filerowObj = new ObservableCollection<FileReaderModel>();
        public ObservableCollection<FileReaderModel> FileRowObj
        {
            get
            {
                return _filerowObj;
            }
            set
            {
                _filerowObj = value;
            }
        }


        private string _filepath;
        public string FilePath 
        {
            get
            {
                return _filepath;
            }
            set
            {
                _filepath = value;
            }
        }


        private void ReadFile(object parameter)
        {
            _filerowObj.Clear();
            StreamReader file = new StreamReader(FilePath);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                FileReaderModel FileReaderobj = new FileReaderModel();

                List<string> Newline = line.Split('\t').Select(p => p.Trim()).ToList();

                FileReaderobj.Id = (Newline[0]);
                FileReaderobj.FirstName = Newline[1];
                FileReaderobj.LastName = Newline[2];
                FileReaderobj.Email = Newline[3];
                switch (Newline[4])
                {
                    case "Male":
                        FileReaderobj.Gender = Gender.Male;
                        break;
                    case "Female":
                        FileReaderobj.Gender = Gender.Female;
                        break;
                }
                FileReaderobj.IPAdd = Newline[5];
                FileReaderobj.Atd = false;

                _filerowObj.Add(FileReaderobj);
            }
        }

        private void WriteFile(object parameter)
        {
            string str = "";
            foreach (var i in FileRowObj)
            {
                str += string.Join("\t", i.Id,i.FirstName, i.LastName, i.Email,i.Gender,i.IPAdd,i.Atd) + "\n";
            }
            System.IO.File.WriteAllText(FilePath, str);
        }
    }
}

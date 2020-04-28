using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileViewer_01
{
    class DataModel
    {
        string _name;
        public string Name 
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int Age { get; set; }

        public DateTime birthday { get; set; }

        List<string> testList = new List<string>();

        public List<string> TestList
        {
            get
            {
                return testList;
            }
            set
            {
                testList = value;
            }
        }

        public DataModel()
        {
            Name = "Nitish";
            Age = 28;
            birthday = new DateTime(2020, 03, 11);
            TestList.Add("Something1");
            testList.Add("Something2");
            testList.Add("Something3");
            testList.Add("Something4");
            testList.Add("Something5");
        }
    }
}

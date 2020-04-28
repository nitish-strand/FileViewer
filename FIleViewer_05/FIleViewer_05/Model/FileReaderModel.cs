using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIleViewer_05.Model
{
    public class FileReaderModel
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public string IPAdd { get; set; }
        public bool Atd { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }
}

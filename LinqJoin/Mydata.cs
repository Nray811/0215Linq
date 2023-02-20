using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqJoin
{
    internal class Mydata
    {
        public string Name
        { get; set; }

        public int Age
        { get; set; }
    }

    class TeacherInfo
    {
        public string ClassName { get; set; }
        public string Teacher { get; set; }
    }
    class StudentInfo
    {
        public string ClassName { get; set; }
        public string Student { get; set; }
    }
    class ResultInfo
    {
        public string ClassName { get; set; }
        public string Teacher { get; set; }
        public string Student { get; set; }
    }
}

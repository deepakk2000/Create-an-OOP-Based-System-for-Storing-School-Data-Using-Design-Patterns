using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Based_System_for_Storing_School_Data
{
    internal class Subject
    {
        public Subject(string name,int subjectCode, string teacherName)
        {
            Name = name;
            SubjectCode = subjectCode;
            TeacherName = teacherName;

        }
        public Subject() { }
        public string Name { get; set; }
        public int SubjectCode { get; set; }
        public string TeacherName { get; set; }
    }
}

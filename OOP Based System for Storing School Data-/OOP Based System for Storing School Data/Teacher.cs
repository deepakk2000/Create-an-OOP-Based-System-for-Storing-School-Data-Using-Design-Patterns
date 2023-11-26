using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Based_System_for_Storing_School_Data
{
    internal class Teacher
    {

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _class;
        public int Class
        {
            get { return _class; }
            set { _class = value; }
        }
        private char _section;
        public char Section
        {
            get { return _section; }
            set { _section = value; }
        }
        public Teacher(string nam, int cla, char sec)
        {
            Name = nam;
            Class = cla;
            Section = sec;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Based_System_for_Storing_School_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------Students--------------");
            //Student Operations
            Console.WriteLine("Enter the Number of The Students");
            int num = int.Parse(Console.ReadLine());
            Student[] stud = new Student[num];
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter Student Name");
                string name = Console.ReadLine();

                Console.WriteLine("Enter Class No");
                int cls = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Section");
                char section = char.Parse(Console.ReadLine());

                stud[i] = new Student(name, cls, section);
                Console.WriteLine("---------------");
            }
            Console.WriteLine("----------------Teacher---------------");
            Console.WriteLine("Enter the No of Teachers :");

            int n1 = int.Parse(Console.ReadLine());

            Teacher[] teach = new Teacher[n1];

            for (int i = 0; i < n1; i++)
            {


                Console.WriteLine("Enter Teacher name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Class No");
                int Class = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Section");
                char section =char.Parse(Console.ReadLine());


                teach[i] = new Teacher(name, Class,section);
                Console.WriteLine("---------------");
            }

            Console.WriteLine("-----------------------------");
            //subject

            Console.WriteLine("--------SUBJECT---------");


            Console.WriteLine("Enter the No of Subject :");

            int n2 = int.Parse(Console.ReadLine());
            
            Subject[] sub = new Subject[n2];

            for (int i = 0; i < n2; i++)
            {

                Console.WriteLine("Enter Subject name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter Subjectcode");
                int code = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Teacher Name");
                string Tname = Console.ReadLine();


                sub[i] = new Subject(name, code,Tname);

                Console.WriteLine("---------------");
            }
            Console.ForegroundColor = ConsoleColor.Blue;



            Console.WriteLine("----------PRINTING DETAILS OF STUDENTS------------------------");

            foreach (var item in stud)
            {


                Console.WriteLine($"Name    : {item.Name}");
                Console.WriteLine($"Class   : {item.Class}");
                Console.WriteLine($"Section : {item.Section}");
                Console.WriteLine("---------------");

            }
            Console.WriteLine("----------PRINTING DETAILS OF TEACHERS------------------------");

            foreach (var item in teach)
            {


                Console.WriteLine($"Name       : {item.Name}");
                Console.WriteLine($"Class      : {item.Class}");
                Console.WriteLine($"Subject    : {item.Section}");
                Console.WriteLine("---------------");

            }

            Console.WriteLine("----------PRINTING DETAILS OF SUBJECTS------------------------");

            foreach (var item in sub)
            {


                Console.WriteLine($"Name           : {item.Name}");
                Console.WriteLine($"Subject Code   : {item.SubjectCode}");
                Console.WriteLine($"Teacher Name   : {item.TeacherName}");
                Console.WriteLine("---------------");

            }

        }
    }
}

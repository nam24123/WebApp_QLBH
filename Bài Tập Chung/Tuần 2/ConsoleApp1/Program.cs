using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        public static List<Student> students = new List<Student>();
        public class Student:IStudentManager
        {
            private string autonumber;
            private string FullName;
            readonly int Id;
            private double DiemTP;
            double DiemThi;
            double DiemKT;
            public static int Number=0;
            public string _Autonumber { get => autonumber; set => autonumber = value; }
            public double _DiemTP { get => DiemTP; set => DiemTP = value; }
            public double _DiemThi { get => DiemThi; set => DiemThi = value; }
            public double _DiemKT { get => DiemKT; set => DiemKT = value; }

            public Student()
            {
            }

            public Student(string fullName, int id, double diemTP, double diemThi, double diemKT)
            {
                Number = Number + 1;
                autonumber ="Ga " + Number.ToString();
                FullName = fullName;
                Id = id;
                DiemTP = diemTP;
                DiemThi = diemThi;
                DiemKT = diemKT;
            }

            public override string ToString()
            {
                return autonumber + " "+ FullName + " " + Id+ " " + DiemTP + " " + DiemThi + " " + DiemKT;
            }
            public void StudentInsert()
            {
                students.Add(this);
            }

            public void StudentUpdate(int id)
            {
                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].Id==id)
                    {
                        /**/
                    }
                }
            }

            public void StudentDelete(int id)
            {
                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].Id == id)
                    {
                        students.RemoveAt(i);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>{
                new Student("Nguyen Huy",1111,5.5,.5,9),
                new Student("Nguyen Hung",1112,5.5,.5,9),
                new Student("Nguyen Huy",1113,5.5,.5,9)
            };
            students = list.GetRange(0,list.Count);
            Student student = new Student();
            student.StudentDelete(1111);
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
        }
    }
}

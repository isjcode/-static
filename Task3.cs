using System;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    class lol
    {
        static void Main()
        {
            Console.WriteLine("Enter a fullname: ");
            string fullname = Console.ReadLine();
            while (!Student.CheckFullName(fullname))
            {
                Console.WriteLine("Incorrect.");
                fullname = Console.ReadLine();
            }
            
            Console.WriteLine("Enter a group name: ");
            string groupno = Console.ReadLine();
            while (!Student.CheckGroupNo(groupno))
            {
                Console.WriteLine("Incorrect.");
                groupno = Console.ReadLine();
            }
            
            
            Console.WriteLine("Enter an age: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Incorrect.");
            }

            Student student = new Student(fullname, groupno, age);

        }
    }
    class Student
    {
        public string Fullname;
        public string GroupNo;
        public int Age;

        public Student(string fullname, string groupno, int age)
        {
            Fullname = fullname;
            GroupNo = groupno;
            Age = age;
        }

        public static bool CheckGroupNo(string no)
        {
            if (no.Length != 4 || !char.IsUpper(no[0]))
            {
                return false;
            }
            else
            {
                for (int i = 1; i < no.Length; i++)
                {
                    if (!char.IsDigit(no[i]))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool CheckFullName(string fullname)
        {
            string[] s = fullname.Split(' ');

            if (s.Length != 2 || !char.IsUpper(s[0][0]) || !char.IsUpper(s[1][0]))
            {
                return false;
            }

            return true;
        }
    } 
}
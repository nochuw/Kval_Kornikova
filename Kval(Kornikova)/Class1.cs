using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Kval_Kornikova_
{
    public class College : IComparable<College>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Teacher> Teachers { get; set; }

        public College(string name, string address)
        {
            Name = name;
            Address = address;
            Teachers = new List<Teacher>();
        }
        public void AddTeacher(Teacher teacher)
        {
            Teachers.Add(teacher);
        }
        public void ShowAll()
        {
            Console.WriteLine($"Название: {Name}");
            Console.WriteLine($"Адрес: {Address} \n");
            Console.WriteLine("Состав преподавателей:");
            foreach (Teacher teacher in Teachers)
            {
                teacher.Show();
            }
        }
        public int CompareTo(College other)
        {
            //Реализация метода сравнения колледжей на основе их имени
            return string.Compare(Name, other.Name, StringComparison.Ordinal);
        }
    }
    public class Teacher
    {
        public string Name { get; set; }
        public string Course { get; set; }

        public Teacher(string name, string course)
        {
            Name = name;
            Course = course;
        }

        public void Show()
        {
            Console.WriteLine("ФИО: " + Name);
            Console.WriteLine("Дисциплина: " + Course);
        }
    }
}

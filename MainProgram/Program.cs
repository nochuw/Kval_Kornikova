using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kval_Kornikova_;

namespace MainProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создание объекта основного класса College
            College college = new College("1Мок", "Староватутинский проезд");

            //Создание объектов вспомогательного класса Teacher
            Teacher tch1 = new Teacher("Ляпина О.П.", "МиАПО \n");
            Teacher tch2 = new Teacher("Гусева А.В.", "МиАПО \n");
            Teacher tch3 = new Teacher("Тузовский А.Ф.", "ТРПО \n");
            Teacher tch4 = new Teacher("Баринова Т.Г.", "Ин.язык");

            //Добавление созданных объектов Teacher в список Teachers класса College
            college.Teachers.Add(tch1);
            college.Teachers.Add(tch2);
            college.Teachers.Add(tch3);
            college.Teachers.Add(tch4);

            //Показ содержимого всех объектов
            college.ShowAll();

            Console.ReadKey();
        }
    }
}

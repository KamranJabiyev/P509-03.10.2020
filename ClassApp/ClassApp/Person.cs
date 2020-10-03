using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp
{
    partial class Person
    {
        public string Name;
        public string Surname;
        public int Age;

        //constructor - method,class adi ile eyni adda olmalidir,return type yoxdur,ayriliqda chagrila bilmez
        //public Person()
        //{
        //    Console.WriteLine("Bir shexs yaradildi");
        //}

        public Person(string name,string surname)
        {
            Name = name;
            Surname = surname;
        }

        public Person(string name, string surname,int age):this(name,surname)
        {
            Age = age;
        }
    }
}

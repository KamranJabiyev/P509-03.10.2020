using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task
            //string[] names = { "Nigar", "Rufet", "Aqil" };
            //Console.WriteLine(CustomJoin(names, "-"));
            #endregion

            #region Class,object
            //string name = "Aqil";
            //string surname = "Beshirov";
            //int age = 26;

            //string name1 = "Zaur";
            //string surname1 = "Necefli";
            //int age1 = 25;

            //anonym object
            //var person1 = new
            //{
            //    name="Aqil",
            //    surname="Beshirov",
            //    age=26
            //};

            //var person2 = new
            //{
            //    name = "Zaur",
            //    surname = "Necefli",
            //    age = 25
            //};

            //Console.WriteLine($"{person2.name} {person2.surname} {person2.age}");

            //instance - nusxe almaq
            //Person p1 = new Person();
            //p1.name = "Aqil";
            //p1.surname = "Beshirov";
            //p1.age = 26;

            //Person p2 = new Person();
            //p2.name = "Reshad";
            //p2.surname = "Xan";
            //p2.age = 27;

            //p1.FullInfo();
            //p2.FullInfo();

            //Person person = new Person();
            //Person person1 = new Person("Aqil", "Beshirov");
            //person1.Name = "Lunatic";
            //Console.WriteLine(person1.Name);

            //Person person2 = new Person("Ayshen", "Quliyeva", 30);
            //person2.FullInfo();

            //Person person3 = new Person();
            //Console.WriteLine(person3.Fullname());

            //Person person4 = new Person();
            //Console.WriteLine(person4.Fullname());

            Developer developer = new Developer("Nigar","Kamran",25,2);
            Person person = new Person("Rufet", "Zulfuqarov", 28);
            Console.WriteLine(developer.FullInfo());
            Console.WriteLine(person.FullInfo());
            //developer.Name = "Nigar";
            //developer.Surname = "Kamran";
            //developer.FullInfo();
            #endregion

        }

        #region Task
        //static StringBuilder CustomJoin(string[] arr,string str)
        //{
        //    StringBuilder result = new StringBuilder();
        //    foreach (string item in arr)
        //    {
        //        result.Append(item);
        //        if(item!=arr[arr.Length-1])
        //            result.Append(str);
        //    }
        //    return result;
        //}
        #endregion
    }
}

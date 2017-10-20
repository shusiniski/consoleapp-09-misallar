using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher[] Mellimler = new Teacher[]
            {
                new Teacher("Yolcu","Nesib", 25),
                 new Teacher("Samir","Dadashzade",36),
                  new Teacher("Ferid","Veliyev", 40),
                   new Teacher("Murad","Muradov",18),
                    new Teacher("Samir","Kerimov",25),

                    

        };
         

            Student[] Telebeler = new Student[]
            {
                 new Student("Kamran","Ferzeliyev",Mellimler[0]),
                 new Student("Anar","Kerimov",Mellimler[1]),
                 new Student("Seymur","Gozelov",Mellimler[1]),
                 new Student("receb","Qarayev",Mellimler[3])
                 
            };

            for (int i = 0; i < Telebeler.Length; i++)
            {
                if (Telebeler[i].Teacher.Name =="Samir" && Telebeler[i].Teacher.Surname=="Dadashzade")
                {

                    Console.WriteLine(Telebeler[i].Name);
                }
            }
            

        }
            class Teacher
        {
            public string Name;
            public string Surname;
            public int Age;

            public Teacher(string name, string surname, int age)
            {
                Name = name;
                Surname = surname;
                Age = age;

               

            }
        }

        class Student
        {
            public string Name;
            public string Surname;
            public Teacher Teacher;

            public Student(string _name, string _surname, Teacher _teacher)
            {
                Name = _name;
                Surname = _surname;
                Teacher = _teacher;
            }
        }
    }
}





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    class Person
    {
        public int age;
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
        public void SetAge()
        {
            Console.WriteLine("Enter Age:");
            age = Convert.ToInt32(Console.ReadLine());
        }
    }
    class Student : Person
    {
        public void study()
        {
            Console.WriteLine("I'm studying on the screen");
        }
        public void ShowAge()
        {
            
            Console.WriteLine("My age is " + this.age + "years old");
        }
    }
    class Professor : Person
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining on the screen");
        }
    }
    class StudentProfessorTest
    { 
        public static void Main()
        {
            Person person = new Person();
            person.Greet();
            Student student = new Student();
            student.SetAge();
            student.ShowAge();
            Professor professor = new Professor();
            professor.SetAge();
            professor.Greet();
            professor.Explain();
            Console.ReadLine();
        }
    }

        
}

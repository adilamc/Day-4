using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assembly1;

namespace Day_4
{
    class Program
    {
        //method
        //public void Display()
        //{
        //    Console.WriteLine("Hi I'm sample assemply");
        //}
        //function
        static void Main(string[] args)
        {
            AssemblyClass assemblyClass = new AssemblyClass();
            Console.WriteLine("Sum ="+ assemblyClass.Sum(1, 2));
            Console.WriteLine("Sub =" + assemblyClass.Sub(4, 2));
            Console.WriteLine("Mul =" + assemblyClass.Mul(3, 2));
            Console.WriteLine("Div =" + assemblyClass.Div(8, 2));
            Console.ReadLine();
        }
    }
}

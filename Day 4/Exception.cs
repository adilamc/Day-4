using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    class MyException:ApplicationException
    {
        public void MyExceptiona()
        {
            Console.WriteLine("An Exception occured");
        }
        public void MyDivideException()
        {
            Console.WriteLine("An Exception occured, Divisor should not be zero");
        }
    }
    class Exception
    {
        public static void Main()
        {
            int x = 5,y=0,z;
            try
            {
               if(y==0)
                {
                    throw new MyException();
                }
            }
            catch(MyException ex)
            {
                ex.MyDivideException();
            }
            Console.ReadLine();
        }
    }
}
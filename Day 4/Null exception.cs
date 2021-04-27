using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    class MyException : ApplicationException
    {

        public void NullException()
        {
            Console.WriteLine("An Exception occured, The object is null");
        }
    }
    class Class10
    {
        public static void Main()
        {
            Class10 c = null;

            try
            {
                
                    if (c == null)
                    {
                        throw new MyException();
                    }
                

            }
            catch (MyException ex)
            {
                ex.NullException();
            }
            Console.ReadLine();
        }
    }
}

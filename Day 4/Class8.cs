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
            Array [] arr = new Array[2];
            
            try
            {
                for(int i=0; i<2;i++)
                {
                    if (arr[i] == null)
                    {
                        throw new MyException();
                    }
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

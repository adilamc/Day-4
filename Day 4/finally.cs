using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    class Class8
    {
        public static void Main()
        {
            int x = 1;
            int y;
            int[] a = new int[1];
            try
            {
                a[2] = 1;
                y = x / 0;
                Console.WriteLine(y);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Some error have occured");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Some error have occured");
            }
            finally
            {
                Console.WriteLine("I'm finally block");
            }
            Console.ReadLine();
        }
    }
}

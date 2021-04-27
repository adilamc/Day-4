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
            try
            {
                y = x / 0;
                Console.WriteLine(y);
            }
            catch
            {
                Console.WriteLine("Some error have occured");
            }
            Console.ReadLine();
        }
    }
}

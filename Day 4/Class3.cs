using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    class Product
    {
        public int SlNumber { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double total { get; set; }

        public void InputValues()
        {
            int i;
            Console.WriteLine("Enter Number of products");
            SlNumber = Convert.ToInt32(Console.ReadLine());
            for(i=0;i<SlNumber;i++)
            {
                Console.WriteLine("Enter ProductName");
                ProductName = Console.ReadLine();
                Console.WriteLine("Enter price");
                Price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter quantity");
                Quantity = Convert.ToInt32(Console.ReadLine());
            }
            
        }
        
        //public void total()
       // {
         
          //  for (int i = 0; i < SlNumber; i++)
            //{
            //    Console.Write(Price * Quantity);
            //}
            
       // }
       
        public int x = 0;
        public void ShowDetails()
        {
            Console.WriteLine("\t \t \t Invoice \n");
            Console.Write("SlNo: \t");
            Console.Write("productname: \t");
            Console.Write("Price \t");
            Console.Write("Quantity \t");
            Console.Write("Total \t");
            for (int i = 0; i < SlNumber; i++)
            {

                Console.WriteLine("\n");
                Console.Write( x++ +"\t");
                
                Console.Write(ProductName + "\t \t");
                
                Console.Write(Price +"\t \t");
                
                Console.Write(Quantity + "\t \t");
                Console.Write(Price * Quantity);

            }
            

        }
    }

    class Class14
    {
        public static void Main()
        {

            Product product = new Product();
            product.InputValues();
            product.ShowDetails();
           // product.total();

            Console.ReadLine();
        }




    }
}

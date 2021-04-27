using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample5
{
    class Program
    {
        class Inventory
        {
            public string ProductName { get; set; }
            public int ProductQuantity { get; set; }
            public double ProductCode { get; set; }
            public void Add()
            {
                Console.WriteLine("Enter the productCode");
                ProductCode = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the productName");
                ProductName = Console.ReadLine();
                Console.WriteLine("Enter the Quantity");
                ProductQuantity = Convert.ToInt32(Console.ReadLine());
            }

        }

        class Customer : Inventory
        {
            
            
            public void PrintInvoice(Customer[] products)
            {
                Console.WriteLine("-------------------Invoice------------------------");
                Console.WriteLine("S.No \t Product Name \t Quantity \t Product Code ");
                int index = 1;
                foreach (var item in products)
                {
                    Console.Write(index);
                    Console.Write("\t");
                    Console.Write(item.ProductName);
                    Console.Write("\t\t");
                    Console.Write(item.ProductQuantity);
                    Console.Write("\t\t");
                    Console.Write(item.ProductCode);
                   
                    Console.Write("\n");
                    index = index + 1;
                }
            }
            public void Buyer()
            {
                Console.WriteLine("Enter the product code");
                int n = Convert.ToInt32(Console.ReadLine());
                

            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter whether u need to Add a product Or  Buy Product Or exit");
            String c = Console.ReadLine();
            if (c.Equals("Add a product"))
            {
                Customer[] products = new Customer[2];

                for (int i = 0; i < products.Length; i++)
                {
                    Customer add = new Customer();
                    add.Add();
                    
                    products[i] = add;
                    
                }
                Customer invoice = new Customer();
                invoice.PrintInvoice(products);

            }
            else if (c.Equals("Buy"))
            {
                Customer buyer = new Customer();
                buyer.Buyer();
            }
            else
            {
                Console.Write("Exit");
            }
            Console.ReadLine();
        }
    }
}

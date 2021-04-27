using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    class Product
    {
        public double ProductCode { get; set; }
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
       
        public int ProductCodeQuantity { get; set; }

        public void GetProductDetails()
        {
            Console.WriteLine("Enter Product Code :");
            ProductCode = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Product Code Quantity :");
            ProductCodeQuantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product Name :");
            ProductName = Console.ReadLine();
            Console.WriteLine("Enter Product Quantity :");
            ProductQuantity = Convert.ToInt32(Console.ReadLine());
            
        }
        
    }
    class Invoice : Product
    {
        string CustomerName { get; set; }
        readonly string InvoiceNumber;
        public void PrintInvoiceBuyer(Product[] products)
        {
            Console.WriteLine("-------------------Invoice------------------------");
            Console.WriteLine("S.No \t Product Name \t Quantity \t ProductCode \t ProductCodeQuantity");
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
                Console.Write("\t\t");
                Console.Write(item.ProductCodeQuantity - item.ProductQuantity);
                Console.Write("\t\t");

                index = index + 1;
            }
        }
        public void PrintInvoiceSeller(Product[] products)
        {
            Console.WriteLine("-------------------Invoice------------------------");
            Console.WriteLine("S.No \t Product Name \t Quantity \t ProductCode \t ProductCodeQuantity");
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
                Console.Write("\t\t");
                Console.Write(item.ProductCodeQuantity + item.ProductQuantity);
                Console.Write("\t\t");

                index = index + 1;
            }
        }
    }
    class User
    {
        public static void Main()
        {
            Console.WriteLine("-------------------Pos Sample Software------------------------");
            //array of objects
            Product[] products = new Product[2];
            Console.WriteLine("Enter the buyer type \n1.Buyer \n2.Wholeseller");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Buyer:");
                    Invoice invoice = new Invoice();
                    invoice.PrintInvoiceBuyer(products);

                    break;
                case 2:
                    Console.WriteLine("Wholeseller:");

                    Invoice invoice1 = new Invoice();
                    invoice1.PrintInvoiceSeller(products);
                    break;
                default:
                    break;

            }

            for (int i = 0; i < products.Length; i++)
            {
                Product product = new Product();
                product.GetProductDetails();
                products[i] = product;
            }
            
            
            Console.ReadLine();
        }
    }
}
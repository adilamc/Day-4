using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample5
{
    
   
 class Inventory
      {
        public string ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public int TotalQuantity { get; set; }
        public double ProductCode { get; set; }
        public double Price { get; set; }
            public void Add()
            {
                Console.WriteLine("Enter the productCode");
                ProductCode = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the productName");
                ProductName = Console.ReadLine();
                Console.WriteLine("Enter the Quantity");
                ProductQuantity = Convert.ToInt32(Console.ReadLine());
            }
            public void Buyer()
            {
                Console.WriteLine("Enter Product Name :");
                ProductName = Console.ReadLine();
                Console.WriteLine("Enter total Quantity :");
                TotalQuantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Product Quantity :");
                ProductQuantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Product Price :");
                Price = Convert.ToDouble(Console.ReadLine());


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

        class InvoiceBuyer : Inventory
        {
            string CustomerName { get; set; }
            readonly string InvoiceNumber;
            public void PrintInvoice1(InvoiceBuyer[] buys)
            {
                Console.WriteLine("-------------------Invoice------------------------");
                Console.WriteLine("S.No \t Product Name \t Quantity \t Price \t Total Price  \t Remaining quantity");
                int index = 1;
                foreach (var item in buys)
                {
                    Console.Write(index);
                    Console.Write("\t");
                    Console.Write(item.ProductName);
                    Console.Write("\t\t");
                    Console.Write(item.ProductQuantity);
                    Console.Write("\t\t");
                    Console.Write(item.Price);
                    Console.Write("\t\t");
                    Console.Write(item.Price * item.ProductQuantity);
                    Console.Write("\t\t");
                    Console.Write(item.TotalQuantity - item.ProductQuantity);
                    Console.Write("\n");
                    index = index + 1;
                }
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
                InvoiceBuyer[] buys = new InvoiceBuyer[2];

                for (int i = 0; i < buys.Length; i++)
                {
                    InvoiceBuyer buy = new InvoiceBuyer();
                    buy.Buyer();

                    buys[i] = buy;

                }
                InvoiceBuyer invoice1 = new InvoiceBuyer();
                invoice1.PrintInvoice1(buys);
            }
            else
            {
                Customer obj = new Customer();
                int exitkey = 1;
                while (exitkey > 0)
                {
                    Console.WriteLine("You want to exit ? Y/N");
                    string choice = Console.ReadLine();
                    if (choice.ToLower() == "y")
                    {
                        break;
                    }
                    
                }

            }
            Console.ReadLine();
        }
    }
}

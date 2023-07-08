using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("Hello. This is the Order by Customer Program.");
        Console.WriteLine();
    
        List<Product> productsList1 = new List<Product>();

        Product product1 =new Product("Milk","aaa", 3.5, 2 );
        Product product2 =new Product("Eggs","bbb", 0.2, 30 );
        productsList1.Add(product1);
        productsList1.Add(product2);

        Address address1 = new Address("Main Street", "Los Angeles", "California", "USA");
        Customer customer1 = new Customer("Juan Diaz", address1);

        Order order1 = new Order(customer1, productsList1);
        
        List<string> packingLabel1 = order1.GetPackingLabel();
        string shippingLabel1 = order1.GetShippingLabel();
        
        Console.WriteLine("ORDEN No. 1: ");
        Console.WriteLine("Packing Label of the Order No. 1: ");
        foreach (string label in packingLabel1)
        {
            Console.WriteLine(label);
        }
        Console.WriteLine();
        Console.WriteLine("Shipping Label of the Order No. 1: ");
        Console.WriteLine(shippingLabel1);

        double totalPriceOrder = order1.GetTotalPriceOrder();

        bool customerInUSA = customer1.CustomerInorOutUSA();

        //if (customerInUSA == true)
        //totalPriceOrder = totalPriceOrder+5;
        //else
        //totalPriceOrder=totalPriceOrder+35;
        Console.WriteLine();
        Console.Write("Total price to be paid by the customer: ");
        Console.WriteLine("$" + totalPriceOrder);
        Console.WriteLine("---------------------------------------------");

        

         List<Product> productsList2 = new List<Product>();

        Product product_a =new Product("Bread","ccc", 4, 3 );
        Product product_b =new Product("Pepsi","ppp", 2.5, 2 );
        productsList2.Add(product_a);
        productsList2.Add(product_b);

        // Las clases Address y Customer las instancio sólo para tener los argumentos de la clase Customer y 
        //Order respectivamente

        Address address_2 = new Address("Av Gabo", "Bucaramanga", "Santander", "Colombia");
        Customer customer_2 = new Customer("Maria Paula Vega", address_2);

        Order order_2 = new Order(customer_2, productsList2);
        
         List<string> packingLabel_2 = order_2.GetPackingLabel();
        string shippingLabel_2 = order_2.GetShippingLabel();
        
        Console.WriteLine("ORDEN No. 2: ");
        Console.WriteLine("Packing Label of the Order No. 2: ");
        foreach (string label2 in packingLabel_2)
        {
            Console.WriteLine(label2);
        }
      
        Console.WriteLine();
        Console.WriteLine("Shipping Label of the Order No. 2: ");
        Console.WriteLine(shippingLabel_2);

        double totalPriceOrder_2 = order_2.GetTotalPriceOrder();

        bool customerInUSA_2 = customer_2.CustomerInorOutUSA();

        //if (customerInUSA == true)
        //totalPriceOrder = totalPriceOrder+5;
        //else
        //totalPriceOrder=totalPriceOrder+35;
        Console.WriteLine();
        Console.Write("Total price to be paid by the customer: ");
        Console.WriteLine("$" + totalPriceOrder_2);
        Console.WriteLine("----------------------------------------------");



    }
}


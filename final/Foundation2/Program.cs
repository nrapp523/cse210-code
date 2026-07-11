using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("LelandCo","585 N 400 E", "Centerville","Utah", "USA");
        Customer customer2 = new Customer("Waterland", "4500 E 700 N","Calgary", "Alberta", "Canada");

        Product product1 = new Product("toaster", "123D", 20, 2);
        Product product2 = new Product("oven", "44M", 400, 2);
        Product product3 = new Product("toothpaste", "45678", 4, 4);

        Product product4 = new Product("soccer ball", "89B", 100, 5);
        Product product5 = new Product("football", "LLM5", 10, 7);
        Product product6 = new Product("baseball", "MLB3", 15, 4);

        Order order1 = new Order();
        order1.addCustomer(customer1);
        order1.addProduct(product1);
        order1.addProduct(product2);
        order1.addProduct(product3);


        Order order2 = new Order();
        order2.addCustomer(customer2);
        order2.addProduct(product4);
        order2.addProduct(product5);
        order2.addProduct(product6);

        order1.CalculateShippingCost();
        order1.TotalCostOfOrder();
        order1.CreatePackingLabel();
        order1.CreateShippingLabel();
        order1.GetPackingLabel();
        order1.GetShippingLabel();
        order1.GetTotalCost();

        order2.CalculateShippingCost();
        order2.TotalCostOfOrder();
        order2.CreatePackingLabel();
        order2.CreateShippingLabel();
        order2.GetPackingLabel();
        order2.GetShippingLabel();
        order2.GetTotalCost();
    }
}
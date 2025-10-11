using System;
using System.Net.Sockets;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 2; i++)
        {
            string[] customerName = new string[2] { "Mr B", "Baz" };
            string[,] customerAddress = new string[2, 4] { { "21 Jump Street", "los Angeles", "California", "USA" }, { "789787 Superman Str", "Whangarei", "Northland", "New Zealand" } };

            string[,] order1 = new string[3, 4] { { "socks", "123", "3.56", "3" }, { "toothpase", "546", "8.12", "5" }, { "clothes", "468", "4.56", "5" } };

            string[,] order2 = new string[3, 4] { { "coffee", "815", "6.31", "2" }, { "dog food", "206", "21.32", "5" }, { "hair gel", "999", "8.37", "5" } };

            Address newAddress = new Address(customerAddress[i, 0], customerAddress[i, 1], customerAddress[i, 2], customerAddress[i, 3]);

            Customer newCustomer = new Customer(customerName[i], newAddress);

            Order newOrder = new Order(newCustomer);

            int j = 0;

            while (j < 3)
            {
                if (i == 0)
                {
                    Product newProduct1 = new Product(order1[j, 0], Convert.ToInt16(order1[j, 1]), float.Parse(order1[j, 2]), Convert.ToInt16(order1[j, 3]));

                    newOrder.AddProducts(newProduct1);

                    j++;
                }
                else
                {
                    Product newProduct2 = new Product(order2[j, 0], Convert.ToInt16(order2[j, 1]), float.Parse(order2[j, 2]), Convert.ToInt16(order2[j, 3]));

                    newOrder.AddProducts(newProduct2);

                    j++;
                }
            }
            newOrder.ShippingLabel();

            newOrder.PackingLabel();

            newOrder.TotalCost();

        }
    }
}
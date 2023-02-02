using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Merchandise> merchandises = new Dictionary<int, Merchandise>();
            List<Client> clients = new List<Client>();

            int id = 1;
            while (true)
            {
                Console.WriteLine("--- Console Menu ---");
                Console.WriteLine("1. Delivery of goods");
                Console.WriteLine("2. Sale of goods");
                Console.WriteLine("3. Availability");
                Console.WriteLine("4. Statistics per client");
                Console.WriteLine("5. General shop statistics");
                Console.WriteLine("6. Create a client");
                Console.WriteLine("7. Back (optional)");
                Console.WriteLine("8. Exit");

                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Delivery of goods selected");
                        Console.WriteLine("Enter merchandise details: ");
                        Console.Write("Enter price: ");
                        int price = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter quantity: ");
                        int quantity = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter category: ");
                        string category = Console.ReadLine() ?? string.Empty;

                        Merchandise merchandise = new Merchandise(id, price, quantity, category);
                        merchandises.Add(id, merchandise);
                        id++;
                        break;
                    case 2:
                        Console.WriteLine("Sale of goods selected");
                        break;
                    case 3:
                        Console.WriteLine("Availability selected");
                        foreach (KeyValuePair<int, Merchandise> item in merchandises)
                        {
                            Console.WriteLine("ID: " + item.Key + " Price: " + item.Value.Price + " Quantity: " + item.Value.Quantity + " Category: " + item.Value.Category);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Statistics per client selected");
                        break;
                    case 5:
                        Console.WriteLine("General shop statistics selected");
                        break;
                    case 6:
                        Console.WriteLine("Create a client selected");
                        Console.Write("Enter client name: ");
                        string name = Console.ReadLine() ?? string.Empty;
                        Console.Write("Enter client number: ");
                        int number = Convert.ToInt32(Console.ReadLine());

                        Client client = new Client(name, number);
                        clients.Add(client);
                        break;
                    case 7:
                        Console.WriteLine("Back selected");
                        break;
                    case 8:
                        Console.WriteLine("Exit selected");
                        return;
                    default:
                        Console.WriteLine("Invalid option, please try again");
                        break;
                }
            }
        }
    }
}
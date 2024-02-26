using ProjectRepositoryPattern.BusinessLogic;
using ProjectRepositoryPattern.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRepositoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessProduct businessProduct = new BusinessProduct(new ProductRepository());
            bool isRunning = true;
            while (isRunning)
            {
                try
                {
                    Console.WriteLine("Type 'L' for List, 'A' for Add, 'U' for Update 'D' for Delete, 'S' for Search,'C' for Clear, 'X' for Exit\n");
                    string command = Console.ReadLine();
                    if (command == "L")
                    {
                        List<Product> _listProduct = businessProduct.Get();
                        Console.WriteLine("List of Products:");
                        Console.WriteLine("------------------------------------------------------------");
                        Console.WriteLine("ProductID\t|\tProductName\t|\tProductCost");
                        Console.WriteLine("------------------------------------------------------------");
                        foreach (Product _product in _listProduct)
                        {
                            Console.WriteLine("\t" + _product.ProductId + "\t|\t" + _product.ProductName + "\t\t|\t" + _product.ProductCost);
                        }
                    }
                    else if (command == "S")
                    {
                        Console.WriteLine("Input a product id to search a Product:");
                        string id = Console.ReadLine();
                        Product aProduct = businessProduct.Get(Convert.ToInt32(id));
                        Console.WriteLine("------------------------------------------------------------");
                        Console.WriteLine("ProductID\t|\tProductName\t|\tProductCost");
                        Console.WriteLine("------------------------------------------------------------");
                        Console.WriteLine("\t" + aProduct.ProductId + "\t|\t" + aProduct.ProductName + "\t\t|\t" + aProduct.ProductCost);
                    }
                    else if (command == "A")
                    {
                        Console.WriteLine("Input a product id to add a Product:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input a product name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input a product cost:");
                        string cost = Console.ReadLine();
                        Product aProduct = new Product();
                        aProduct.ProductId = Convert.ToInt32(id);
                        aProduct.ProductName = name;
                        aProduct.ProductCost = Convert.ToInt32(cost);
                        bool isExecuted = businessProduct.Add(aProduct);
                        if (isExecuted)
                        {
                            Console.WriteLine("Successfully added a new Produt.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to add a new Product.");
                        }
                    }
                    else if (command == "U")
                    {
                        Console.WriteLine("Input a product id to update a Product:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input a product name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input a product cost:");
                        string cost = Console.ReadLine();
                        Product aProduct = new Product();
                        aProduct.ProductId = Convert.ToInt32(id);
                        aProduct.ProductName = name;
                        aProduct.ProductCost = Convert.ToInt32(cost);
                        bool isExecuted = businessProduct.Update(aProduct);
                        if (isExecuted)
                        {
                            Console.WriteLine("Successfully updated a Product.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to update.");
                        }
                    }
                    else if (command == "D")
                    {
                        Console.WriteLine("Input a product id to delete a Product:");
                        string id = Console.ReadLine();
                        bool isExecuted = businessProduct.Delete(Convert.ToInt32(id));
                        if (isExecuted)
                        {
                            Console.WriteLine("Successfully deleted a Product.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to delete.");
                        }
                    }
                    else if (command == "C")
                    {
                        Console.Clear();
                    }
                    else if (command == "X")
                    {
                        isRunning = false;
                    }
                    else
                    {
                        Console.WriteLine("Command not found.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }//Main
    }//Class
}//Namespace

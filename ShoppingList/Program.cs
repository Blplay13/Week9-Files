using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @$"C:\Users\Tatjana\Samples\shopping";
            string fileName = @"\\shoppingList.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> shoppingList = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you like to add an item to your list? Y/N");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter an item:");
                    string newItem = Console.ReadLine();
                    shoppingList.Add(newItem);
                }
                else
                {
                    Console.WriteLine("Take care!");
                    loopActive = false;
                }
            }

            Console.Clear();

            foreach (string item in shoppingList)
            {
                Console.WriteLine($"You have in your list: {item}");
            }

            File.WriteAllLines($"{fileLocation}{fileName}", shoppingList);



        }

        /*public static string ItemsToShop()
        {
            List<string> shoppingList = new List<string>();
            shoppingList.Add("new jeans");
            shoppingList.Add("a red T-shirt");
            shoppingList.Add("winter boots for hiking");
            shoppingList.Add("a cosy sweater");
            shoppingList.Add("a pair of socks for my partner");
            shoppingList.Add("automatic feeder for my cat");
            Console.WriteLine(shoppingList.Count + " items in list:");
            foreach (string item in shoppingList)
            {
                Console.WriteLine(item);
            }*/
        }
    }
}

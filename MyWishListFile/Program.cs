﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWishListFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\Tatjana\Samples\wishlist";
            string fileName = @"\\mywishlist.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> myWishList = arrayFromFile.ToList<string>();

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Would you like to add a wish? Y/N");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Enter your wish:");
                    string userWish = Console.ReadLine();
                    myWishList.Add(userWish);
                }
                else
                {
                    Console.WriteLine("Take care!");
                    loopActive = false;
                }
            }

            Console.Clear();

            foreach (string wish in myWishList)
            {
                Console.WriteLine($"You wish: {wish}");
            }

            File.WriteAllLines($"{fileLocation}{fileName}", myWishList);
        }
    }
}

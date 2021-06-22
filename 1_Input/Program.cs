using System;

namespace _1_Input
{
    class Program
    {
        static string playerName;
        static void Main(string[] args)
        {
            Console.WriteLine("----- GAME START -----");
            Console.WriteLine();
            Console.WriteLine("Hello! Whats your name?");
            playerName = Console.ReadLine();
            Console.WriteLine($"Hello, {playerName}!");
            Console.WriteLine("Want to save your progress? [y/n]");
            string choice = Console.ReadLine().ToLower();
            if (choice == "y" || choice == "yes")
            {
                Console.WriteLine("Too bad! idk how to write a file in C#!");
                Console.WriteLine("...yet");
            }
            else
            {
                Console.WriteLine("Oh ok. Im not sure how to do that anyway.");
            }
        }
    }
}

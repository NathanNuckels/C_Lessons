using System;

namespace _2_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome back to my second C# program!\nuhhh... what was your name again?");
            string playerName = Console.ReadLine();
            Console.WriteLine("Ok. I promice not to forget it again if you let me save it to a file.");
            Console.WriteLine("Allow .NET FRAMEWORK to save files? [Y/n]");
            string choice = Console.ReadLine().ToLower();
            if (choice == "n" || choice == "no")
            {
                Console.WriteLine(":( I really wanted to show you");
            }
            else
            {
                Console.WriteLine("Alrighty! one moment...");
                await WriteAllText.write("Name.txt",playerName);
                Console.WriteLine("Check 'Name.txt' in the same folder as this cs file.");
            }
        }
    }
}

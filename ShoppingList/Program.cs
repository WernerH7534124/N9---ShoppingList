using System;
using System.IO;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Teeme uued poe nimekirjad?");
            Console.WriteLine("  ");
            string rootDirectory = @"C:\Users\werne\source\samples";
            Console.WriteLine(" Sisesta kausta nimi:");
            string newDirectory = Console.ReadLine();
            Console.WriteLine("Sisesta nimekirja nimetus ja lõppu .txt :");
            string fileName = Console.ReadLine();

            if (Directory.Exists($"{rootDirectory}\\{newDirectory}") && File.Exists($"{rootDirectory}\\{newDirectory}\\{fileName}"))
            {
                Console.WriteLine($"Directory and File exist at {rootDirectory}");
            }
            else
            {
                Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
                File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");
            }



        }
    }
}
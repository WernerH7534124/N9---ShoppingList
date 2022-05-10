using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
           {
                string fileLocation = @"C:\Users\werne\source\samples\Aprill";
                string fileName = @"\\Nädal20.txt";

                int i = 0; 

                string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
                List<string> poenimekiri = arrayFromFile.ToList<string>();

                bool loopActive = true;

                while (loopActive)
                {
                    Console.WriteLine("Kas lisame midagi nimekirja? Y/N:");
                    char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                    if (userInput == 'y')
                    {
                        Console.WriteLine("Mida siis poest vaja? Pane kirja:");
                        string ese = Console.ReadLine();
                        poenimekiri.Add(ese);
                    }
                    else
                    {
                        loopActive = false;
                        Console.WriteLine("Ja nüüd - Poodi!");
                    }

                    Console.Clear();

                    Console.WriteLine($"Sinu poe nimekiri:");
                    Console.WriteLine($"  ");

                    foreach (string wish in poenimekiri)
                    {
                        Console.WriteLine($"{wish}");
                    }
                    Console.WriteLine($"  ");

                    File.WriteAllLines($"{fileLocation}{fileName}", poenimekiri);
                }
    }

    }

    }
}
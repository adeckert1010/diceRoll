using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using DiceRoll.Dice;


namespace DiceRoll
{
    class Program
    {

        static void Main(string[] args)
        {

            /*
            foreach(KeyValuePair<int, string> kvp in DieFaces.dieFaceDictionary)
            {
                int numm = kvp.Key;
                string str = kvp.Value;
                Console.WriteLine($"{str}");
            }
            Console.ReadLine();
            Console.WriteLine(DieFaces.dieFaceDictionary);
            Console.ReadLine();
            */

            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Choose how many sides the die has (2-20): ");
            int numOfSides = int.Parse(Console.ReadLine());
            Dictionary<int, string> dieFaceDictionary = new Dictionary<int, string>(numOfSides + 1);

            foreach (KeyValuePair<int, string> kvp in DieFaces.dieFaceDictionary)
            {
                int number = kvp.Key;
                string face = kvp.Value;
                if (numOfSides > number)
                {
                    dieFaceDictionary.Add(number, face);
                }
            }

            foreach (KeyValuePair<int, string> kvp in dieFaceDictionary)
            {
                int numm = kvp.Key;
                string str = kvp.Value;
                Console.WriteLine($"{str}");
            }
            Console.ReadLine();


            while (true)
            {
                Console.WriteLine("Press Enter to roll the dice or q to quit");
                string input = Console.ReadLine();
                if (input == "q" || input == "Q")
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    int timeCount = 1;
                    for (int i = 0; i < 90; i++)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(GetRandomDieFace());
                        Console.SetCursorPosition(0, 0);
                        Thread.Sleep(timeCount);
                        timeCount += 1;
                        
                    }
                   
                    Console.WriteLine(GetRandomDieFace());
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                }
            }
            string GetRandomDieFace()
            {
                List<int> keyList = new List<int>(dieFaceDictionary.Keys);
                Random rand = new Random();
                int randomKey = keyList[rand.Next(keyList.Count)];
                return dieFaceDictionary[randomKey];
            }
        }
    }
}

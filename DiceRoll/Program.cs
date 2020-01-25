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
            Console.OutputEncoding = Encoding.UTF8;
            Dictionary<int, string> dieFaceDictionary = DieFaces.dieFaceDictionary;
        

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

using System.Reflection.Emit;
using System.Security.Cryptography;
using System;
using System.IO;

namespace DayThree
{
    internal class Program
    {
        static void Main(string[] args)
        {


            void SwitchExpression()
            {
                int choice = default;
                string response;
                response = choice switch
                {
                    1 => "Ye rest and recover your health.",
                    2 => "Raiding the port town get ye 50 gold doubloons.",
                    3 => "The wind is at your back; the open horizon ahead.",
                    4 => "'Tis but a baby Kraken, but still eats toy boats.",
                    _ => "Apologies. I do not know that one." 
                    //has to use wildcard "_" because it cant use default
                };
                Console.WriteLine(response);
            }

            void Loops()
            {
                int playersNumber = -1;
                while (playersNumber < 0 || playersNumber > 10)
                {
                    Console.Write("Enter a number between 0 and 10: ");
                    
                    playersNumber = Convert.ToInt32(Console.ReadLine());
                }
            }

            void DoWhileLoop()
            //executes the code first, evaluates the condition second ensuring the loop runs at least once
            {
                int playersNumber;
                do
                {
                    Console.Write("Enter a number between 0 and 10: ");
                    playersNumber = Convert.ToInt32(Console.ReadLine());
                }
                while (playersNumber < 0 || playersNumber > 10);
            }

            void InfiniteWhileAndBreak()
            {
                while (true)
                {
                    Console.Write("Think of a number and type it here: ");
                    string input = Console.ReadLine();

                    if (input == "quit" || input == "exit") break; //exits the loop even if the condition is true

                    int number = Convert.ToInt32(input);
                    if (number == 12)                        
                    {
                        Console.WriteLine("I don't like that number. Pick another one.");
                        continue; //continues to the next itteration of the loop while skipping the rest of the code within the loop
                    }
                    Console.WriteLine($"I like {number}. It's the one before {number + 1}!");
                }
            }

            void NestedForLoop()
            {
                //multiplication table
                for (int a = 1; a <= 10; a++)
                    for (int b = 1; b <= 10; b++)
                        Console.WriteLine($"{a} * {b} = {a * b}");

                //displaying an amount of rows and collums
                int totalRows = 5;
                int totalColumns = 10;
                for (int currentRow = 1; currentRow <= totalRows; currentRow++)
                {
                    for (int currentColumn = 1; currentColumn <= totalColumns; currentColumn++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }

            void UserLooped()
            {
                FileInfo fileInfo = new FileInfo("C: \\Users\\Korisnik\\Desktop\\73Z_2108.w032.n003.52B.p1.52.jpg");

                Console.WriteLine("Guess number hihi");
                int numberToGuess = RandomNumberGenerator.GetInt32(0, 101);
                Console.WriteLine(numberToGuess);

                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (userNumber == numberToGuess) { Console.WriteLine("YAAY, you guessed it"); }

                else File.Delete("C: \\Users\\Korisnik\\Desktop\\73Z_2108.w032.n003.52B.p1.52.jpg");
            }

            void UserLoopedTheSecond()
            {
                try
                {
                    string filePath = @"C: \Users\Korisnik\Desktop\73Z_2108.w032.n003.52B.p1.52.jpg";
                    File.Delete(filePath);
                    Console.WriteLine("File deleted successfully.");
                }
                catch (Exception e)
                {
                    Console.WriteLine("An error occurred: " + e.Message);
                }
                string Wait = Console.ReadLine();
            }
           
        }
    }
}
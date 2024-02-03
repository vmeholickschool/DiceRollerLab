using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Grand Circus Casino");

        string userInput;

        do
        {
            Console.WriteLine("Please enter the number of sides you want for your pair of dice: ");

            int numberOfSides = 0;

            // Use a loop 
            while (!int.TryParse(Console.ReadLine(), out numberOfSides) || numberOfSides < 1)
            {
                Console.WriteLine("Your input is invalid. Please enter a positive numeric value: ");
            }

            Console.WriteLine("Please Roll your dice.");

            Random randomGenerator = new Random();
            int diceRoll1 = randomGenerator.Next(1, numberOfSides + 1);
            int diceRoll2 = randomGenerator.Next(1, numberOfSides + 1);

            Console.WriteLine($"You rolled a {diceRoll1} and a {diceRoll2}\nTotal: {diceRoll1 + diceRoll2}");

            if (numberOfSides == 6)
            {
                CheckForSpecialCombinations(diceRoll1, diceRoll2);
                CheckForSpecialCombinations1(diceRoll1, diceRoll2);
            }

            else if (numberOfSides == 4)
            {
                CheckForSpecialCombinations3(diceRoll1, diceRoll2);
            }
            Console.WriteLine("Do you want to roll the dice again? (yes/no): ");

            // Use a loop for exception handling
            userInput = Console.ReadLine().ToLower();
            while (userInput != "yes" && userInput != "no")
            {
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no': ");
                userInput = Console.ReadLine().ToLower();
            }

        } while (userInput == "yes");

        Console.WriteLine("Thanks for playing!");
    }

    private static void CheckForSpecialCombinations(int diceRoll1, int diceRoll2)
    {
        if (diceRoll1 == 1 && diceRoll2 == 1)
        {
            Console.WriteLine("Snake Eyes!");
        }
        else if (diceRoll1 == 1 && diceRoll2 == 2 || diceRoll1 == 2 && diceRoll2 == 1)
        {
            Console.WriteLine("Ace Deuce");
        }
        else if (diceRoll1 == 6 && diceRoll2 == 6)
        {
            Console.WriteLine("Box Cars");
        }
        else
        {
            Console.WriteLine("");
        }
    }

    private static void CheckForSpecialCombinations1(int diceRoll1, int diceRoll2)
    {
        if (diceRoll1 + diceRoll2 == 7 || diceRoll1 + diceRoll2 == 11)
        {
            Console.WriteLine("Win!");
        }
        else if (diceRoll1 + diceRoll2 == 2 || diceRoll1 + diceRoll2 == 3 || diceRoll1 + diceRoll2 == 12)
        {
            Console.WriteLine("Craps");
        }
        else
        {
            Console.WriteLine("");
        }
    }

    private static void CheckForSpecialCombinations3(int diceRoll1, int diceRoll2)
    {
        if (diceRoll1 + diceRoll2 == 4 || diceRoll1 + diceRoll2 == 6)
        {
            Console.WriteLine("Win!");
        }
        else
        {
            Console.WriteLine("");
        }
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Grand Circus Casino");

        do
        {
            Console.WriteLine("Please enter the number of sides you want for your pair of dice: ");

            int numberOfSides = 0;
            int.TryParse(Console.ReadLine(), out numberOfSides);
            while (!int.TryParse(Console.ReadLine(), out numberOfSides) || numberOfSides < 1)
            {
                Console.WriteLine("Your input is invalid. Please enter a positive numeric value: ");
            }
            Console.WriteLine("Please Roll your dice.");
            Random randomGenerator = new Random();
            int randomIntiger = randomGenerator.Next();
            int newRandomInteger = randomGenerator.Next();
            int diceRoll1 = randomGenerator.Next(0, 10);
            int diceRoll2 = randomGenerator.Next(0, 10);

            if (numberOfSides == 6 && diceRoll1 == 1 && diceRoll2 == 1)
            {
                //Console.WriteLine($"Roll 1:\n You rolled a {diceRoll1} and a {diceRoll2}\n "(diceRoll1 + diceRoll2) \n Snake Eyes ")

            }
        }
}
}
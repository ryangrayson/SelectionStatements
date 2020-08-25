using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can you guess the secret number??");
            Console.WriteLine("Guess between 1 and whatever number you choose.\n" +
                "Type the number you choose below:");

            var userResponse = Console.ReadLine();

            var upperLimit = int.Parse(userResponse);

            var random = new Random();
            var number = random.Next(1,upperLimit);

            Console.WriteLine("Input your guess");

            var guess = int.Parse(Console.ReadLine());

            if(guess > number)
            {
                Console.WriteLine("WRONG! Too high, nerd!");
            }
            else if(guess < number)
            {
                Console.WriteLine("WRONG Too low, nerd!");
            }
            else
            {
                Console.WriteLine("Well done! ...Nerd");
            }


        }
    }
}

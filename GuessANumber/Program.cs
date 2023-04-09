namespace GuessANumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random randomNum= new Random();
            int computerNumber=randomNum.Next(1,100);
            int br = 0;
            while (true)
            {
                Console.WriteLine("Guess a number(1-100): ");
                string input=Console.ReadLine();
                bool isValid=int.TryParse(input, out int playerNumber);
                if (isValid) {
                    if (playerNumber==computerNumber)
                    {
                        Console.WriteLine("You guessed it! :)");
                        break;
                    }
                    else if (playerNumber>computerNumber)
                    {
                        Console.WriteLine("Too High");
                    }
                    else 
                    {
                        Console.WriteLine("Too Low");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
                br++;
                if (br>=5)
                {
                    Console.WriteLine("You don't have any other attempts.");
                    Console.WriteLine("Sorry :(");
                    Console.WriteLine($"The number was {computerNumber}");
                    
                    break;
                }
            }
        }
    }
}
namespace Antra_hw4;

public class Guessing
{
    public void game()
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 4); // Generates a random number between 1 and 3

        Console.WriteLine("Guess the number between 1 and 3:");

        while (true)
        {
            int guessedNumber;
            try
            {
                guessedNumber = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                continue;
            }

            if (guessedNumber < 1 || guessedNumber > 3)
            {
                Console.WriteLine("Your guess is outside the valid range. Please guess a number between 1 and 3.");
            }
            else if (guessedNumber < randomNumber)
            {
                Console.WriteLine("Your guess is too low.");
            }
            else if (guessedNumber > randomNumber)
            {
                Console.WriteLine("Your guess is too high.");
            }
            else
            {
                Console.WriteLine("You guessed the correct number.");
                break;
            }
        }
    }
}
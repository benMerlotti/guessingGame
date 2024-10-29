Random random = new Random();
int secretNumber = random.Next(1, 101);
int totalGuesses = 0;

Console.WriteLine("Guess the secret number!");
Console.WriteLine(@"But first CHOOSE A DIFFICULTY:
1. Easy
2. Medium
3. Hard
4. Infinite");

int chosenDifficulty = 0;
bool validDifficulty = false;

while (!validDifficulty)
{
    try
    {
        chosenDifficulty = int.Parse(Console.ReadLine());

        if (chosenDifficulty < 1 || chosenDifficulty > 4)
        {
            Console.WriteLine("Please enter a number between 1 and 4 for the difficulty");
        }
        else
        {
            validDifficulty = true;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid input. Please enter a number between 1 and 4 for the difficulty.");
    }
}
if (chosenDifficulty == 1)
{
    totalGuesses = 9;
}
else if (chosenDifficulty == 2)
{
    totalGuesses = 7;
}
else if (chosenDifficulty == 3)
{
    totalGuesses = 5;
}
else if (chosenDifficulty == 4)
{
    totalGuesses = int.MaxValue;
}


int userGuess = 0;

int numberOfGuesses = 1;



while (userGuess != secretNumber && numberOfGuesses < totalGuesses)
{
    Console.WriteLine($"YOUR GUESS ({totalGuesses - numberOfGuesses} LEFT):");
    userGuess = int.Parse(Console.ReadLine());
    numberOfGuesses++;


    if (userGuess < secretNumber)
    {
        Console.WriteLine("Too low. Try again.");
    }
    else if (userGuess > secretNumber)
    {
        Console.WriteLine("Too high. Try again.");
    }
    else if (userGuess == secretNumber)
    {
        Console.WriteLine("SUCCESS. Wow I can't believe you guessed that.");
    }

}

if (userGuess != secretNumber)
{
    Console.WriteLine("Sorry mate you've run out of guesses.");
}




Random topSecret = new();
int secretNumber = topSecret.Next(1, 101);
int guessCount = 0;

while (true)
{
    guessCount++;
    Console.WriteLine("Skriv en siffra mellan 1 och 100: ");
    int guess = int.Parse(Console.ReadLine()!);
    if (guess == secretNumber)
    {
        Console.WriteLine($"Du gissa på nummer {secretNumber} och har vunnit ett avgassystem från datsun!!");
        Console.WriteLine($"Det tog dig {guessCount} försök att gissa rätt.");
        break;
    }
    else
    {
        Console.WriteLine("Försök igen!");
    }
}
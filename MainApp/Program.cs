/// <summary>
/// Gissa det hemliga numret mellan 1 och 100.
/// </summary>

Random topSecret = new();
// Skapa ett hemligt nummer med topSecret mellan 1 och 100
int secretNumber = topSecret.Next(1, 101);
// Skapa en variabel för att räkna gissningar med startvärde 0
int guessCount = 0;

// Loop för att gissa numret
while (true)
{
    // Öka gissningsräknaren med 1
    guessCount++;
    Console.WriteLine("Skriv en siffra mellan 1 och 100: \n");
    int guess = int.Parse(Console.ReadLine()!);
    // Om gissningen är rätt
    if (guess == secretNumber)
    {
        Console.WriteLine($"Du gissa på nummer {secretNumber} och har vunnit ett avgassystem från datsun!! Det var väl roligt?!");
        Console.WriteLine($"Det tog dig {guessCount} försök att gissa rätt.");
        break;
    }
    // Om inmatning är fel och försök igen
    else
    {
        Console.WriteLine("Fel, försök igen!");
    }
}
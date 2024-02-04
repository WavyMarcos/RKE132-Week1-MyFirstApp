// This is a comment to my code

// Rakendus küsib kasutaja nime
// Rakendus tervitab kasutajat nime pidi

Console.WriteLine("Enter your name:");
// string - sõne
string userName = Console.ReadLine();

Console.WriteLine("Hello, " + userName + "!");

// string interpolation
Console.WriteLine($"Hello, {userName}!");
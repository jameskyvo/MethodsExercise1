string name;
string timeOfFight;
string colorOfGoblins;
string locationOfFight;
string favoriteWeapon;

void AskPlayerInputs()
{
    Console.WriteLine("What is the name of your hero?");
    name = Console.ReadLine();
    Console.WriteLine("What time of day does this occur?");
    timeOfFight = Console.ReadLine();
    Console.WriteLine("What is your least favorite color?");
    colorOfGoblins = Console.ReadLine();
    Console.WriteLine("Where would you like your dream home to be?");
    locationOfFight = Console.ReadLine();
    Console.WriteLine("What is your favorite weapon?");
    favoriteWeapon = Console.ReadLine();
}

AskPlayerInputs();
Console.WriteLine($"You're relaxing in your home in {locationOfFight} when your door suddenly slams open.");
Console.WriteLine($"\"{name}!\" You hear a young boy shrieking your name.");
Console.WriteLine($"\"The {colorOfGoblins} goblins are invading all of {locationOfFight}! More are set to arrive at {timeOfFight}. We must defend ourselves!\"");
Console.WriteLine($"You sigh. This isn't how you wanted to spend your vacation, but it's your job, and somebody has to do it.");
Console.WriteLine($"Grab your { favoriteWeapon}, it's time to work.");
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Welcome, challenger");
Thread.Sleep(1000);
Console.WriteLine("To the maze of death");
Thread.Sleep(1000);
System.Console.WriteLine("Enter the name to write on your tomb");

string name = Console.ReadLine();
while (true)
{
    if (name != "")
    {
        break;
    }
    else if (name == "")
    {
        System.Console.WriteLine("Please state your name");
        name = Console.ReadLine();
    }
}

Thread.Sleep(1500);
System.Console.WriteLine($"Well then {name}, I hope you're ready to face your fears.\n");
Thread.Sleep(1000);



Random generator = new Random();
// int rounds = generator.Next(3,6);
List<string> enemies = new List<string>();
enemies.Add("Slime");
enemies.Add("Goblin");
enemies.Add("Orc");

// Console.WriteLine(enemies[2]);


// int index = generator.Next(myList.Count);
// System.Console.WriteLine(myList[index]);

Console.WriteLine("You enter the maze and approach a fork in the road. Which way do you choose? Left or Right");
string a = Console.ReadLine().ToLower();

if (a == "right" || a == "r")
{
    Console.WriteLine("You continue walking to the right when you suddenly sight a silhouette lurking in the shadows. Do you approach?");
    a = Console.ReadLine().ToLower();
    if (a == "yes" || a == "y")
    {
        int q = generator.Next(enemies.Count);
        string enemy = enemies[q];
        Console.WriteLine($"You walk towards the silhouette and you encounter a {enemy}.\n As you have no way to escape you fight the {enemy}");
        // method for fighting
    }
    else
    {
        Console.WriteLine("You decide to not approach the silhouette and contine on your way walking past the mysteries in the shadows.");
    }
}

if (a == "left" || a == "l")
{
    Console.WriteLine("You take the path to the left and you end up walking in circles.");
    Thread.Sleep(1000);
    Console.WriteLine("After walking for what seems like an eternity you stumble upon an abandoned house emerged in the walls of the maze.");
    Thread.Sleep(1000);
    System.Console.WriteLine("Do you wish to enter the house?");
    
    a = Console.ReadLine().ToLower();
    if (a == "yes" || a == "y")
    {
        System.Console.WriteLine("After a moment of staring at the house like an idiot, you think to yourself \"Why not take a look in the house\".");
        System.Console.WriteLine("");
    }
}







Console.ReadLine();


// (int hp,string name)  enemy = (100, "simdisd");

// enemy.hp;


Direction();

void Direction()
{
    System.Console.WriteLine();
}
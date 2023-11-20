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
    }
}

Thread.Sleep(1000);
System.Console.WriteLine($"Well then {name}, I hope you're ready to face your fears.");
Thread.Sleep(1000);



// Random generator = new Random();
// int rounds = generator.Next(3,6);

// List<string> enemies = new List<string>();

Console.WriteLine("You enter the maze and approach a fork in the road. Which way do you choose? Left or Right");
string a = Console.ReadLine().ToLower();



Console.ReadLine();
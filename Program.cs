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

Thread.Sleep(1000);
System.Console.WriteLine($"Well then {name}, I hope you're ready to face your fears.");
Thread.Sleep(1000);



Random generator = new Random();
// int rounds = generator.Next(3,6);
// List<string> enemies = new List<string>();

// int x = 20;
// int y = 35;
// int z = 50;
// List<int> myList = new List<int>() {x,y,z};
// int index = generator.Next(myList.Count);
// System.Console.WriteLine(myList[index]);

Console.WriteLine("You enter the maze and approach a fork in the road. Which way do you choose? Left or Right");
string a = Console.ReadLine().ToLower();

if (a == "right" || a == "r")
{
    Console.WriteLine("You continue walking to the right when you suddenly sight a silhouette. Do you approach?");
    a = Console.ReadLine().ToLower();
    if (a == "yes" || a == "y")
    {
        
    }
}








Console.ReadLine();
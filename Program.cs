bool playOn = true;

while (playOn)
{
    Game();
}

void Game()
{
    Console.WriteLine("Spel: ");
    Console.WriteLine("1. Sten Sax Påse");
    Console.WriteLine("2. Gissa talet");
    Console.WriteLine("3. Avsluta programmet");
    Console.Write("\nVad vill du spela?: ");

    int input = int.Parse(Console.ReadLine()!);

    switch (input)
    {
        case 1:
            Stensaxpase();
            break;
        case 2:
            Gissatalet();
            break;
        case 3:
            Console.WriteLine("Hejdå!");
            playOn = false;
            break;
    }
}

void Stensaxpase()
{
    Console.Clear();
    var list = new List<string> { "sten", "sax", "påse" };

    Random random = new Random();
    string cpu = list[random.Next(0, 3)];

    Console.WriteLine("Sten, sax eller påse?");
    string input = Console.ReadLine()!.ToLower();

    if (cpu == "sten" && input == "sax")
    {
        Console.WriteLine($"Du förlorade mot {cpu}");
    }
    else if (cpu == "sax" && input == "påse")
    {
        Console.WriteLine($"Du förlorade mot {cpu}");
    }
    else if (cpu == "påse" && input == "sten")
    {
        Console.WriteLine($"Du förlorade mot {cpu}");
    }
    else if (cpu == input)
    {
        Console.WriteLine("Oavgjort!");
    }
    else
    {
        Console.WriteLine($"Du vann mot {cpu}");
    }
}

void Gissatalet()
{
    Console.Clear();
    Random random = new Random();
    int cpuNumber = random.Next(1, 11); //1 - 10

    while (true)
    {
        Console.WriteLine("Gissa ett tal mellan 1 til 10");
        int userInput = int.Parse(Console.ReadLine()!);

        if (cpuNumber > userInput)
        {
            Console.WriteLine("Talet är högre");
            continue;
        }
        else if (cpuNumber < userInput)
        {
            Console.WriteLine("Talet är lägre");
            continue;
        }
        else
        {
            Console.WriteLine("Korrekt!");
            break;
        }
    }
}

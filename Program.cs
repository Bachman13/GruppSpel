//Test

Random random = new Random();
int cpuNumber = random.Next(1, 101);

while (true)
{
    Console.WriteLine("Gissa ett tal mellan 1 til 100");
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
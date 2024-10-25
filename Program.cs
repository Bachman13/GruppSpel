//Test
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



// Random random = new Random();
// int cpuNumber = random.Next(1, 101);

// while (true)
// {
//     Console.WriteLine("Gissa ett tal mellan 1 til 100");
//     int userInput = int.Parse(Console.ReadLine()!);

//     if (cpuNumber > userInput)
//     {
//         Console.WriteLine("Talet är högre");
//         continue;
//     }
//     else if (cpuNumber < userInput)
//     {
//         Console.WriteLine("Talet är lägre");
//         continue;
//     }
//     else
//     {
//         Console.WriteLine("Korrekt!");
//         break;
//     }
// }

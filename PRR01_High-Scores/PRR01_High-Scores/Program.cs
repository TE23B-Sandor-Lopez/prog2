
List<string> scores = [];

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Skriv namn på en polare:");
    string name = Console.ReadLine();

    Console.WriteLine("Poängsätt din polare:");
    string points = Console.ReadLine();
    scores.Add(points + " " + name);
}

foreach (string score in scores)
{
    Console.WriteLine(score);
}
Console.ReadLine();
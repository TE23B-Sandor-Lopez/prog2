int p1Hp = 100;
int p2Hp = 200;

Console.WriteLine("Välj en username");
string p1Name = Console.ReadLine();
string p2Name = "";

while (p1Hp > 0 && p2Hp > 0)
{
  Console.WriteLine($"{p1Name}: {p1Hp}");
  Console.WriteLine($"{p2Name}: {p2Hp}");
  p2Hp -= Random.Shared.Next(10, 25); // Alex slår Calin
  p1Hp -= Random.Shared.Next(25, 50); // Calin slår Alex
  Console.ReadLine();
}

if (p1Hp > 0)
{
  Console.WriteLine($"Nej, {p2Name} vann! wooomp womp");
}
else if (p1Hp <= 0 && p2Hp <= 0)
{
  Console.WriteLine($"{p2Name} vann! woomp womp");
}
else
{
  Console.WriteLine($"{p2Name} vann! woomp womp");
}

Console.ReadLine();
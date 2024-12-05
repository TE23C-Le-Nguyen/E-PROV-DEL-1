Console.WriteLine("What is your max hp?");
int hp = 0;
int times = 0;
int hpbar = 0;
string hptext = Console.ReadLine();
bool success = int.TryParse(hptext, out hp);
while (false)
{
    Console.WriteLine("this is not a number");
}


while (hp > 0)
{
    Console.WriteLine($"[{hp}]");
    
    hp--;
}

List<string> name = [Console.ReadLine()];
while (hp >= times)
{
    name.Add("[]");
    times++;
}
Console.ReadLine();
int a = new Random().Next(1, 1000000);
Console.WriteLine(a);
if (a < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    while (a > 1000)
    {
        a = a / 10;
    }
    Console.WriteLine(a % 10);
}
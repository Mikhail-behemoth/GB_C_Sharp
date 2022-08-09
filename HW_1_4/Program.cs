int n = 0;
Console.WriteLine("Введите число");
n = Convert.ToInt32(Console.ReadLine());
if (n > 0)
{
    for (int i = 1; i <= n; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write( i + " ");
        }
        else
        {
            Console.Write("");
        }
    }
}
else
{
        for (int i = n; i <= 1; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write( i + " ");
        }
        else
        {
            Console.Write("");
        }
    }
}
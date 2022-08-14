Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0)
{
    for (int i = 1; i <= n; i++)
    {
        Console.Write( i * i * i);
        
        if (i < n)
        {
            Console.Write(", ");
        }
        
    }
}
else
{
        for (int i = n; i <= 1; i++)
    {
        Console.Write( i * i * i);
        
        if (i < 1)
        {
            Console.Write(", ");
        }
    }
}
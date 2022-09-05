Console.WriteLine("Введите N");
int n = int.Parse(Console.ReadLine());

void RecursionFromItoOne(int i)
{
    if (i == 1)
    {
        Console.Write($"{i}");
    }
    else
    {
        Console.Write($"{i} ");
        i--;
        RecursionFromItoOne(i);
    }
}

RecursionFromItoOne(n);
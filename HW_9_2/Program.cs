Console.WriteLine("Введите первое число");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int n = int.Parse(Console.ReadLine());

int SumNumbersBetweenIandJ (int i, int j)
{
    if (i > j)
    return 0; 
    if (i == j)
    return i;
    return SumNumbersBetweenIandJ (i+1, j) + i;
}

Console.Write($"Сумма чисел от {m} до {n} равна {SumNumbersBetweenIandJ (m,n)}");
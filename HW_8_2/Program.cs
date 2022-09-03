int [,] array = new int [4, 2];

void FillArray(int[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
arr [i, j] = new Random().Next (1,10);
}
}

void PrintArray(int[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write($"{arr[i, j]} ");
    }
Console.WriteLine();
}
}

FillArray(array);
PrintArray(array);
Console.WriteLine();

int Sum = 0, Sum1 = 0, Sum2 = 0, RowMin = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    Sum2 = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Sum2 += array [i,j];
    }
    if (Sum2 < Sum1)
    {
        Sum = Sum2;
        RowMin = i;
    }
     Sum1 = Sum2;
}
Console.WriteLine($"наименьшая сумма элементов в строке {Sum}");
Console.WriteLine($"номер строки с наименьшей суммой элементов {RowMin+1}");
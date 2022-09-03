int [,] array = new int [3, 4];

void FillArray(int[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
arr [i, j] = new Random().Next (1,100);
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

void OrderDescending(int[,] arr)
{
    for (int c = 0; c < arr.GetLength(0); c++)
        for (int i = 0; i < arr.GetLength(1); i++)
            for (int j = 0; j < arr.GetLength(1) - 1; j++)
                if (arr[c, j] < arr[c, j + 1])
                {
                    int temp = arr[c, j];
                    arr[c, j] = arr[c, j + 1];
                    arr[c, j + 1] = temp;
                }
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
OrderDescending(array);
PrintArray(array);
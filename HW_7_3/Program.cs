int [,] array = new int [2, 3];

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
{Console.Write($"{arr[i, j]} ");}
Console.WriteLine();
}
}

FillArray(array);
PrintArray(array);
Console.WriteLine();

double avrg = 0;
for (int j = 0; j < array.GetLength(1); j++)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
    avrg += array [i, j];
    }
    avrg = avrg / array.GetLength(0);
    Console.Write(avrg + " ");
    avrg = 0;
}
int [,] array1 = new int [2, 2];
int [,] array2 = new int [2, 2];

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

FillArray(array1);
PrintArray(array1);
Console.WriteLine();
FillArray(array2);
PrintArray(array2);
Console.WriteLine();

int [,] array3 = new int [2, 2];

for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        for (int k = 0; k < array2.GetLength(0); k++)
        {
            array3[i,j] += array1[i,k] * array2[k,j];
        }
    }
}

PrintArray(array3);
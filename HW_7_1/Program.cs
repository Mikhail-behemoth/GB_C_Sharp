Console.WriteLine("Введите длину строки в массиве");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк в массиве");
int n = Convert.ToInt32(Console.ReadLine());
double [,] array = new double [m, n];

void FillArray(double[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
arr [i, j] = Math.Round(new Random().NextDouble ()*new Random().Next (-1000, 1000), 2);
}
}

void PrintArray(double[,] arr)
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
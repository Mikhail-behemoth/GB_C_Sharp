int [,] array = new int [5, 10];

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

Console.WriteLine("Введите номер строки элемента в массиве");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца элемента в массиве");
int n = Convert.ToInt32(Console.ReadLine());

if (m <= array.GetLength(0) && n <= array.GetLength(1))
{
    Console.WriteLine(array[m-1, n-1]);
}
else
{
    Console.WriteLine("Элемента с таким номером в массиве нет");
}
void FillArray (int [] arr)
{
for (int i = 0; i < arr.Length; i++)
{
arr [i] = new Random().Next (-100,100);
}
}

void PrintArray (int [] arr)
{
for (int i = 0; i < arr.Length; i++)
{
Console.Write($"{arr [i]} ");
}
}

int [] array = new int [5];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int sum = 0;
for (int i = 0; i < array.Length; i++)
 {
    if (i % 2 != 0)
    {
     sum += array[i];
    }
 }
 Console.WriteLine(sum);
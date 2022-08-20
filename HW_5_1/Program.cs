void FillArray (int [] arr)
{
for (int i = 0; i < arr.Length; i++)
{
arr [i] = new Random().Next (100,1000);
}
}

void PrintArray (int [] arr)
{
for (int i = 0; i < arr.Length; i++)
{
Console.Write($"{arr [i]} ");
}
}

int [] array = new int [8];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int count = 0;
for (int i = 0; i < array.Length; i++)
 {
    if (array[i] % 2 ==0)
    {
     count++;
    }
 }
 Console.WriteLine(count);
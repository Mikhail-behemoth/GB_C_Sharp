void FillArray (double [] arr)
{
for (int i = 0; i < arr.Length; i++)
{
arr [i] = new Random().NextDouble ();
}
}

void PrintArray (double [] arr)
{
for (int i = 0; i < arr.Length; i++)
{
Console.Write($"{arr [i]} ");
}
}

double [] array = new double [5];
FillArray(array);
PrintArray(array);
Console.WriteLine();
double maxnum = array[0];
double minnum = array[0];
for (int i = 1; i < array.Length; i++)
 {
    if (array[i] > maxnum)
    {
     maxnum = array[i];
    }
     if (array[i] < minnum)
    {
     minnum = array[i];
    }
 }
 Console.WriteLine(maxnum - minnum);
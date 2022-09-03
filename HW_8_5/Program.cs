Console.WriteLine("Введите количество элиментов в строке");
int n=int.Parse(Console.ReadLine());

int[,] arr = new int[n, n];
int k = 1;
int temp = 0;
int i,j=0;
int n1 = n;

while (k <= n1 * n1)
{
    for (i = temp; i < n; i++)
    {
        arr[j, i] = k++;
    }
    j=i-1;
    for (i = temp+1; i < n; i++)
    {
        arr[i, j] = k++;
    }
    for (i = n - 2; i >= temp; i--)
    {
        arr[j, i] = k++;
    }
    j=temp;
    for(i=n-2;i>temp;i--)
    {
        arr[i, j] = k++;
    }
    n--;
    temp++;
    j = temp;
}

for (i = 0; i < arr.GetLength(0); i++)
{
      for (j = 0; j < arr.GetLength(1); j++)
           Console.Write("{0,3} ", arr[i, j]);
      Console.WriteLine();
}
int[, ,] array = new int[2, 2, 2];

static void FillPrintArray(int[, ,] arr)
{
    Random p = new Random();
    int k = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int l = 0; l < arr.GetLength(2); l++)
            {
                int a2 = p.Next(10, 100);
                for (int q = 0; q < arr.GetLength(0); q++)
                    for (int w = 0; w < arr.GetLength(1); w++)
                        for (int x = 0; x < arr.GetLength(2); x++)
                            if (a2 != arr[q, w, x])
                            k++;
                            if (k == arr.GetLength(0)*arr.GetLength(1)*arr.GetLength(2))
                            {
                                arr[i, j, l] = a2;
                                k = 0;
                            }
                            else
                            {
                                k = 0;
                                l = (l - 1);
                                continue;
                            }
                            Console.Write($"({i},{j},{l}) {arr[i, j, l]} ");
            }
        Console.WriteLine();
        Console.WriteLine();        
        }
    }
}
    
FillPrintArray (array);
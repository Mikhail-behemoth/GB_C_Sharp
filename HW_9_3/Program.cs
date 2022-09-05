int AckermannFunc(int m, int n) 
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0)
    {
        return AckermannFunc(m - 1, 1);
    }
    return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
}
 
Console.WriteLine(AckermannFunc(3, 2));
Console.WriteLine("Введите пятизначное число");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 10000 | a > 99999)
{
    Console.WriteLine("число не пятизначное");
}
else
{
    int a1 = a % 10;
    int a5 = a / 10000 % 10;
    if (a1 == a5)
    {
        int a2 = a / 10 % 10;
        int a4 = a / 1000 % 10;    
        if (a2 == a4)
        {
            Console.WriteLine("Палиндром");
        }
        else
        {
            Console.WriteLine("Не палиндром");
        }
    }
    else
    {
        Console.WriteLine("Не палиндром");
    }
}
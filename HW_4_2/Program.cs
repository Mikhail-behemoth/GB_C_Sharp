Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int a1 = Math.Abs(a);
int sum_a = 0;
while (Math.Abs(a) > 0)
{
    a1 = Math.Abs(a) % 10;
    sum_a = sum_a + a1;
    a = a / 10;
}
Console.WriteLine($"сумма чисел числа = {sum_a}");
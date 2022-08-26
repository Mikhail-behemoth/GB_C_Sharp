Console.WriteLine("Введите b1");
int B1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k1");
int K1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2");
int B2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2");
int K2 = Convert.ToInt32(Console.ReadLine());

void intersectionPointCoordinates (int b1, int k1, int b2, int k2)
{
double x = ((double)(b2-b1)/(k1-k2));
double y = k1*x + b1;
Console.WriteLine($"({x}, {y})");
}

intersectionPointCoordinates(B1, K1, B2, K2);
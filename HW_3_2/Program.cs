Console.WriteLine("Введите X1");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y1");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z1");
int Z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите X2");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y2");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z2");
int Z2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(X1-X2,2)+Math.Pow(Y1-Y2,2)+Math.Pow(Z1-Z2,2));

Console.Write("d = " + d);
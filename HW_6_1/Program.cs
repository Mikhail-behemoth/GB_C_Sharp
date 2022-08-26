Console.WriteLine("Введите числа через пробел");
string[] nums_string = Console.ReadLine().Split();

void CountNaturalNumbers (string [] str)
{
int[] arr = new int[str.Length];
for (int i = 0; i < arr.Length; i++)
{
arr[i] = Convert.ToInt32(str[i]);
}
int count = 0;
for (int i = 0; i < arr.Length; i++)
 {
    if (arr[i] > 0)
    {
     count ++;
    }
 }
 Console.WriteLine($"количество чисел больше нуля равно {count}");
}

CountNaturalNumbers(nums_string);
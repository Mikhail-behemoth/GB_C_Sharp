
Console.WriteLine("Введите восемь чисел через пробел");
string[] nums_strings = Console.ReadLine().Split();
int[] nums = new int[nums_strings.Length];
if (nums_strings.Length > 8)
{
    for(int i = 0; i < 8; i++)
    {
    nums[i] = Convert.ToInt32(nums_strings[i]);
    Console.Write(nums[i] + " ");
    }
}
else
{
    for(int i = 0; i < nums_strings.Length; i++)
    {
    nums[i] = Convert.ToInt32(nums_strings[i]);
    Console.Write(nums[i] + " ");
    } 
}
Console.Clear();
Console.WriteLine("Введите массив строк через пробел: ");
string[] str1 = Console.ReadLine().Split(" ");
string[] str2 = new string[str1.Length];
void InputArray(string[] str11, string[] str2)
{
    int count = 0;
    for (int i = 0; i < str1.Length; i++)
    {
    if(str1[i].Length <= 3)
        {
        str2[count] = str1[i];
        count++;
        }
    }
}
void PrintArray(string[] str)
{
    for (int i = 0; i < str.Length; i++)
    {
        Console.Write($"{str[i]} ");
    }
    Console.WriteLine();
}
InputArray(str1, str2);
PrintArray(str2);
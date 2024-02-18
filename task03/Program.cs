// Задача 3: 
// Задайте произвольную строку. 
// Выясните, является ли она палиндромом.

void CheckStrForPalindrom(string str)
{
    int j = str.Length - 1;
    str = str.ToLower();
    for (int i = 0; i < str.Length / 2; i++)
    {
        if (str[i] != str[j - i])
        {
            Console.WriteLine("Строка не является полиндромом");
            return;
        }
    }
    Console.WriteLine("Строка является полиндромом");
}

Console.Write("Введите текст: ");
string inputString = Console.ReadLine();
CheckStrForPalindrom(inputString);
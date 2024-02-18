// Задача 1: 
// Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

void PrintMatrix(char[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

string GetArrayToString(char[,] matrix)
{
    string result = string.Empty;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result = result + matrix[i,j];
        }
    }
    return result;
}

char[,] charsArray = {
    {'q', 'w', 'e', 'r'},
    {'a', 's', 'd', 'f'},
    {'z', 'x', 'c', 'v'}
};
PrintMatrix(charsArray);
Console.WriteLine(GetArrayToString(charsArray));
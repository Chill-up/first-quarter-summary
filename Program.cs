// Задача: написать программу, которая из имеющегося массива строк формирует массив из строк длина которых меньше или равна 3 символа.

void PrintArrayString(string[] array)
{
    int arrSize = array.Length;
    if (arrSize == 0) Console.WriteLine("[]");
    else
    {
        Console.Write("[ ");
        for (int i = 0; i < arrSize; i++)
        {
            if (i < arrSize - 1) Console.Write($"{array[i]}, ");
        }
        Console.Write($"{array[arrSize - 1]} ]");
    }
}

int CountValidElements(string[] array, int num)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= num) count++;
    }
    return count;
}

string[] FindStringLessNChars(string[] array, int numberChars)
{
    int length = array.Length;
    int counter = CountValidElements(array, numberChars);
    string[] res = new string[counter];
    int j = 0;
    for (int i = 0; i < length; i++)
        if (array[i].Length <= numberChars)
        {
            res[j] = array[i];
            j++;
        }
    return res;
}

Console.Clear();
Console.WriteLine("Имеется массив строк:");
// Строки из примера
string[] startArray = { "hello", "2", "world", ":-)" };
//string[] startArray = { "1234", "1567", "-2", "computer science" };
//string[] startArray = { "Russia", "Denmark", "Kazan" };

string[] resultArray = FindStringLessNChars(startArray, 3);

PrintArrayString(startArray);
Console.WriteLine();
Console.WriteLine("Массив из строк, длина которых меньше или равна 3 символа:");
PrintArrayString(resultArray);
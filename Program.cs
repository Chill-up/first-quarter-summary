// Задача: написать программу, которая из имеющегося массива строк формирует массив из строк длина которых меньше или равна 3 символа.

void PrintArrayString(string[] array)
{
    int arrSize = array.Length;
    Console.Write("[");
    for (int i = 0; i < arrSize; i++)
    {
        if (i < arrSize - 1 && array[i] != null) Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[arrSize - 1]}]");
}

string[] FindStringLess3Chars(string[] array, int numberChars)
{
    int length = array.Length;
    string[] res = new string[length];
    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= numberChars)
        {
            res[i] = array[i];
        }
    }
    return res;
}
Console.Clear();
Console.WriteLine("Имеется массив строк:");
// Строки из примера
string[] startArray = { "hello", "2", "world", ":-)" };
// string[] startArray = { "1234", "1567", "-2", "computer science" };
// string[] startArray = {"Russia", "Denmark", "Kazan"};

string[] resultArray = FindStringLess3Chars(startArray, 3);

PrintArrayString(startArray);
Console.WriteLine();
Console.WriteLine("Массив из строк, длина которых меньше или равна 3 символа:");
PrintArrayString(resultArray);
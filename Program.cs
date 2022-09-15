// Задача: написать программу, которая из имеющегося массива строк формирует массив из строк длина которых меньше или равна 3 символа.

Console.WriteLine("Имеется массив строк:");
//string[] stringArray = { "hello", "2", "world", ":-)" };
string[] stringArray = {"1234", "1567", "-2", "computer science"};
void PrintArrayString(string[] array)
{
    int arrSize = array.Length;
    Console.Write("[");
    for (int i = 0; i < arrSize; i++)
    {
        if (i < arrSize - 1) Console.Write($"{array[i]}, ");
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

string[] resultArray = FindStringLess3Chars(stringArray, 3);

PrintArrayString(stringArray);
System.Console.WriteLine();
PrintArrayString(resultArray);
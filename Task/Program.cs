Console.OutputEncoding = System.Text.Encoding.UTF8;

string[] textArray1 = new string[]{"hello", "2", "world", ":-)"};
string[] textArray2 = new string[]{"1234", "1567", "-2", "computer scince"};
string[] textArray3 = new string[]{"Russia", "Denmark", "Kazan"};

string[] GetTextArrayMaxWithThreeSymbols(string[] arr)
{
    string[] newArr = new string[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        char[] symbols = arr[i].ToCharArray();
        if (symbols.Length <= 3) newArr[i] = arr[i];
    }
    return newArr.Where(x => x != null).ToArray();
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

Console.WriteLine("\nИсходные массивы:");
PrintArray(textArray1);
PrintArray(textArray2);
PrintArray(textArray3);

Console.WriteLine("\nРезультат:");
string[] res1 = GetTextArrayMaxWithThreeSymbols(textArray1);
PrintArray(res1);
string[] res2 = GetTextArrayMaxWithThreeSymbols(textArray2);
PrintArray(res2);
string[] res3 = GetTextArrayMaxWithThreeSymbols(textArray3);
PrintArray(res3);
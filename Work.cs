string[] text = { 'test', 'avocado', '268', 'cat', '45', 'JS', 'sweet+', 'yes', 'time', 'C#' };

string[] stringThreeSymbols(string[] str)
{
    int count = 0;
    string[] temp = new string[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        char[] a = text[i].ToCharArray();
        if (a.Length <= 3)
        {
            temp[count] = text[i];
            count++;
        }
    }
    string[] result = new string[count];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = temp[i];
    }
    System.Console.WriteLine($"Final array: {count}");
    return result;
}

string [] result = stringThreeSymbols (text);

System.Console.Write("Result: ");

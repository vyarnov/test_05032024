string[] CreateConvertArray(string[] array)
{
    string[] newArray = new string[CountNumber(array)];
   
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        string res = array[i];
        if (res.Length < 4)
        {
            newArray[j] = res;
            j++;
        }

    }
    return newArray;
}

int CountNumber(string[] array)
{
    int sumNumber = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string res = array[i];
        if (res.Length < 4)
        {
            sumNumber++;
        }

    }
    return sumNumber;
}

string[] array = new string[] { "Hello", "2", "world", ":-)" };
Console.WriteLine($"Массив исходный: [{string.Join(", ", array)}]");
string[] newArray = CreateConvertArray(array);
Console.WriteLine($"Массив измененный: [{string.Join(", ", newArray)}]");

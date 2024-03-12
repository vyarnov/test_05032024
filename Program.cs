string[] ConvertArray(string[] array)
{
    string[] newArray = new string[4];
   
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


string[] array = new string[] { "Hello", "2", "world", ":-)" };
Console.WriteLine($"Массив исходный: [{string.Join(", ", array)}]");
string[] newArray = ConvertArray(array);
Console.WriteLine($"Массив измененный: [{string.Join(", ", newArray)}]");
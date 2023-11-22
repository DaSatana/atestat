
string[] arr = new string[] { "Hello", "2", "world", ":-)" };

string[] result = FilterArray(arr);

Console.WriteLine("Исходный массив:");
PrintArray(arr);
Console.WriteLine("Отфильтрованный массив:");
PrintArray(result);


static string[] FilterArray(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }

    string[] result = new string[count];
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            result[index] = arr[i];
            index++;
        }
    }

    return result;
}

static void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}
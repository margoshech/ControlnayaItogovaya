void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = System.Console.ReadLine(); 
    }
}

void PrintArray(string[] array)
{
    System.Console.WriteLine("Вы ввели: ");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }

    System.Console.WriteLine();
}

string[] CreateNewArray(string[] array)
{
    string[] resultArray = new string[array.Length];
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length<=3)
        {
            resultArray[i] = array[i];
        }
    }
    return resultArray.Where(element => !string.IsNullOrEmpty(element)).ToArray();
}

string[] array = new string[5];
System.Console.WriteLine("Введите элементы массива");
FillArray(array);
PrintArray(array);
PrintArray(CreateNewArray(array));

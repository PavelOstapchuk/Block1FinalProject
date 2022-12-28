// Задача: Написать программу, 
// которая из имеющегося массива строк
// формирует новый массив из строк, длина которых меньше,
// либо равна 3 символам. 
// Первоначальный массив задаy на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
Console.Clear();
string[] array = { "one", "2", ":-)", "three", "3", "four", "4", "six", "6" };
Console.WriteLine($"Начальный массив:");
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"Массив, из строк, длина которых меньше или равна 3 символам:");
string[] arrayOfThree = GetNewStringArrayOfLess(array, 3);
Console.WriteLine($"[{String.Join(", ", arrayOfThree)}]");
Console.WriteLine();
//---methods---
string[] GetNewStringArrayOfLess(string[] array, int k)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= k) count += 1;
    }
    string[] newArray = new string[count];
    for (int i = 0, j = 0; (i < array.Length && j < count); i++, j++)
    {
        if (array[i].Length <= 3) newArray[j] = array[i];
        else j -= 1;
    }
    return newArray;
}

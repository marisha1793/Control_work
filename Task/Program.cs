/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина
которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо
задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами. */

Console.WriteLine("Введем список всех элементов массива: ");
string[]array = CreateArray();
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Из всего списка оставим только те, чья длина не более 3 символов: ");
string[]newArray = SortArray(array);
PrintArray(newArray);


string[] SortArray(string[] array)
{
    int index = 0;
    string[] newArray = new string [array.Length];
    for (var i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            newArray[index] = array[i];
            index++; 
        }
    }
    return newArray;
}


void PrintArray(string[]array)
{
    Console.Write("[");
    for (var i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length-1]);
    Console.Write("]");
}

string[] CreateArray()
{
    string[] array = new string [5];
    array[0] = "hello";
    array[1] = "hi";
    array[2] = "bye";
    array[3] = "one";
    array[4] = "hoho";
    return array;
}

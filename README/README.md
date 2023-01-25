# Описание решения задачи

В начале создадим исходный массив, который наполнен строками разной длины:
```
string[]array = new string [5] {"hello", "hi", "bye", "one", "hohoho"};
```

Затем выведем этот массив в консоль с помощью метода **PrintArray**:
```
void PrintArray(string[]ar)
{
    for (var i = 0; i < ar.Length; i++)
    {
        Console.Write($"{ar[i]} ");
    }
}
```
Затем создадим новый массив на основе исходного, который будет состоять из элементов, длина которых не превышает 3 символа. Для создания нового массива используем метод **SortArray**:
```
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
```
В конце выводим новый массив в консоль с помощью метода **PrintArray**.
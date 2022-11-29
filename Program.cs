// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

string[] inputArray = {"hello", "2", "world", ":-)"};

void ShowStringArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(i == 0) Console.Write(array[i]);
        else Console.Write(", " + array[i]);
    }
    Console.WriteLine();
}

ShowStringArray(inputArray);

int CountValuesMatchingToSize(string[] array, int stringSize)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if(array[i].Length <= stringSize) count++;
    return count;
}

string[] CreateOutputArray(string[] array, int arraySize, int stringSize)
{
    string[] outputArray = new string[arraySize];
    for (int i = 0, j = 0; i < arraySize; j++)
    {
        if(array[j].Length <= stringSize)
        {
            outputArray[i] = array[j];
            i++;
        }
    }
    return outputArray;
}

int stringSize = 3;

int arraySize = CountValuesMatchingToSize(inputArray, stringSize);

string[] outputArray = CreateOutputArray(inputArray, arraySize, stringSize);

ShowStringArray(outputArray);
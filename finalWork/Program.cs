// Написать программу, которая из имеющего масива строк формирует массив из строк, 
// длина которых меньше или равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string[] array = new string[6] { "321", "112", ":D", "22", "aaaaaaaaaaaaaaaaa", "ye" };

int NumberElements(string[] arr, int minСharacters)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= minСharacters) count += 1;
    }
    return count;
}

string[] CreateArrayMinCharasters(string[] arr, int minNumbChar, int minСharacters)
{
    string[] arrayMinNumbChar = new string[minNumbChar];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= minСharacters)
        {
            arrayMinNumbChar[j] = arr[i];
            j++;
        }
    }
    return arrayMinNumbChar;
}

void PrintArray(string[] arr)
{
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine(" ]");
}


int numberElements = NumberElements(array, 3);
string[] arrayMinNumCharasters = CreateArrayMinCharasters(array, numberElements, 3);

Console.WriteLine("Имеющийся массив: ");
PrintArray(array);
Console.WriteLine("\nМассив из строк, длина которых меньше либо равна 3 символам:");
PrintArray(arrayMinNumCharasters);
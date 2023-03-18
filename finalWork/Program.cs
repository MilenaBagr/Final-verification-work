﻿// Написать программу, которая из имеющего масива строк формирует массив из строк, 
// длина которых меньше или равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string [] array = new string [6] {"Work", "IT",":D", "aaaaaaaaaaaa", "12!/13", "ye"};

int NumberElements (string [] arr, int minСharacters)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
       if  (arr[i].Length <= minСharacters) count+=1;
    }
    return count;
}

Console.WriteLine("Имеющийся массив: ");
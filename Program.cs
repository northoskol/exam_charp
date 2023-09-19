// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите элементы массива (через пробел): ");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');
        // Определяем количество строк в массиве, которые имеют длину <= 3 символам
        int count = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }
        // Создаем новый массив для строк длиной <= 3 символам
        string[] resultArray = new string[count];
        int index = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                resultArray[index] = str;
                index++;
            }
        }
    }
}
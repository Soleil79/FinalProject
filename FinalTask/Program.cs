/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

using System;
class Program
{
    static void FillArray (string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Введите {i+1} элемент массива : ");
            array[i] = Convert.ToString(Console.ReadLine());
        }          
    }
    static void PrintArray (string [] array)
    {
        Console.Write("[ ");
        for (int i = 0; i < array.Length; i++)
        {
            if (i < array.Length -1) Console.Write(array[i] + ", ");
            else Console.Write(array[i] + " ");

        }
        Console.WriteLine("]");
    }
    static string [] FillNewArray (string [] array)
    {		
		int count = 0;
        int i = 0;
        string [] newArray = new string [array.Length];
        
        while (i < array.Length)
        {
            if(array[i].Length <= 3)
            {
                newArray[count] = array[i];
                count++;
            }
            i++;
        }
          Array.Resize(ref newArray, count);
          return newArray;
    }

    static void Main ()
    {
        string [] StringArray = new string [5];
        FillArray(StringArray);
        Console.WriteLine("Представлен следующий массив строк:");
        PrintArray(StringArray);
        string [] NewStringArray = FillNewArray(StringArray);
        Console.WriteLine("Новый массив строк, элементы которого содержат не более 3 символов:");
        PrintArray(NewStringArray);
    }
}

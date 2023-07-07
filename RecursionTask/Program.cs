using System;

namespace RecursionTask;

class Progam
{
    static void Main(string[] args)
    {
        int[] array = { 5, 2, 6, -2, 0, -3, 10, 33, 9, -1 };
        PrintArrayElements(array);
    }

    static void PrintArrayElements(int[] array, int index = 0)
    {
        if (index >= array.Length) 
        {
            return;
        }

        if (array[index] < 0) 
        {
            Console.Write(array[index] + " ");
        }

        PrintArrayElements(array, index + 1); 

        if (array[index] >= 0) 
        {
            Console.Write(array[index] + " ");
        }
    }
}
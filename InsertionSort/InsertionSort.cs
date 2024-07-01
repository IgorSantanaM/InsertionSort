using System;

public class InsertionSort
{
    private int[] data; // Array of values
    private static Random generator = new Random();

    // Constructor to create array of given size and fill with random integers
    public InsertionSort(int size)
    {
        data = new int[size]; // Create space for array

        // Fill array with random ints in range 10-99
        for (int i = 0; i < size; ++i)
            data[i] = generator.Next(10, 100);
    }
    public void PrintPass(int pass, int index)
    {
        Console.Write($"after pass {pass}: ");

        for (int i = 0; i < index; ++i)
            Console.Write(data[i] + " ");

        Console.Write(data[index] + "* "); // Indicate swap

        // Finish outputting array
        for (int i = index + 1; i < data.Length; ++i)
            Console.Write(data[i] + " ");

        Console.Write("\n"); // For alignment

        // Indicate amount of array that is sorted
        for (int i = 0; i <= pass; ++i)
            Console.Write("-- ");
        Console.WriteLine("\n"); // Skip a line in output
    }

    public void Sort()
    {
        int insert; 

        for (int next = 1; next < data.Length; ++next)
        {
            insert = data[next];
            int moveItem = next;

            while (moveItem > 0 && data[moveItem - 1] > insert)
            {
                data[moveItem] = data[moveItem - 1];
                moveItem--;
            }

            data[moveItem] = insert; 
            PrintPass(next, moveItem);
        }
    }
    public override string ToString()
    {
        string temporary = string.Empty;

        // Iterate through array
        foreach (int element in data)
            temporary += element + " ";

        temporary += "\n"; 
        return temporary;
    }
}

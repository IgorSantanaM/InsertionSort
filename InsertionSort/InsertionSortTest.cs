using System;

public class InsertionSortTest
{
    public static void Main(string[] args)
    {
        
        InsertionSort sortArray = new InsertionSort(10);

        Console.WriteLine("Unsorted array:");
        Console.WriteLine(sortArray); 

        sortArray.Sort(); 

        Console.WriteLine("Sorted array:");
        Console.WriteLine(sortArray); 
    }
}

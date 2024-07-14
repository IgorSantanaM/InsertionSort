# InsertionSort

A C# implementation of the Insertion Sort algorithm, which sorts an array of randomly generated integers.

## Features

- Generates an array of random integers within the range of 10-99.
- Sorts the array using the Insertion Sort algorithm.
- Provides visual output for each pass of the sorting process.

## Table of Contents

- [Installation](#installation)
- [Usage](#usage)
- [Example](#example)
- [Output](#output)
- [Contributing](#contributing)
  
## Installation

To run this project, you need to have [.NET](https://dotnet.microsoft.com/download) installed on your machine.

1. Clone the repository:
    ```bash
    git clone https://github.com/yourusername/InsertionSort.git
    ```
2. Navigate to the project directory:
    ```bash
    cd InsertionSort
    ```
3. Build the project:
    ```bash
    dotnet build
    ```

## Usage

1. Run the project:
    ```bash
    dotnet run
    ```
2. You can also specify the size of the array by editing the code in `Program.cs` (if applicable):
    ```csharp
    int size = 20; // Example array size
    InsertionSort sorter = new InsertionSort(size);
    ```

## Example

Here is an example of how to use the `InsertionSort` class in a C# project:

```csharp
using System;

public class Program
{
    public static void Main(string[] args)
    {
        int size = 10; // Specify the size of the array
        InsertionSort sorter = new InsertionSort(size);

        Console.WriteLine("Original array:");
        Console.WriteLine(sorter);

        sorter.Sort();

        Console.WriteLine("Sorted array:");
        Console.WriteLine(sorter);
    }
}
```
## Output 
During the sorting process, the program prints each pass of the algorithm. For example:

``` bash
Original array:
45 78 12 34 90 56 67 89 23 11 

after pass 1: 45* 78 12 34 90 56 67 89 23 11 
-- 

after pass 2: 12 45* 78 34 90 56 67 89 23 11 
-- -- 

after pass 3: 12 34 45* 78 90 56 67 89 23 11 
-- -- -- 

...

Sorted array:
11 12 23 34 45 56 67 78 89 90
```
## Contributing
Contributions are welcome! Please fork the repository and submit a pull request with your changes. For major changes, please open an issue first to discuss what you would like to change.

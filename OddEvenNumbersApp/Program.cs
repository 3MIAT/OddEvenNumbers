// See https://aka.ms/new-console-template for more information
//
int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9};

Console.WriteLine("Hello, World!");

foreach (var n in numbers)
{
  Console.WriteLine($"{n}");
}

static bool IsEven(int number) => number % 2 == 0;

static bool IsOdd (int number) => !IsEven(number);


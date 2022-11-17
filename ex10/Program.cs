// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("введите трёхзначное число: ");

int number = int.Parse(Console.ReadLine());

int result = (number % 100) / 10;

Console.WriteLine($"{number} -> {result}");

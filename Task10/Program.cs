// Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехначное число. ");
int num = Convert.ToInt32(Console.ReadLine());
int num2x = num % 100 / 10;
Console.WriteLine($"{num} -> {num2x}");

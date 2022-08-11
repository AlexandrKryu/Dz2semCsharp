// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
Console.WriteLine("Введите число от 1 до 7. ");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 6)
{
    Console.WriteLine($"{num}->да");
}
else if (num == 7)
    {
    Console.WriteLine($"{num}->да");
    }
else 
{
Console.WriteLine($"{num}->нет");
}
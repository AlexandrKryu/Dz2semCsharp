// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число. ");
int number = Convert.ToInt32(Console.ReadLine());
int FunctThree(int num)
{
    if (num > 99)
    {
        while (num > 1000)
        {
            num = num / 10;
        }    
        return num % 10; 
    }    
    else return -1;
}
FunctThree(number);
int result = FunctThree(number);
if (result != -1)
{
    Console.WriteLine($"{number} ->{result}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}


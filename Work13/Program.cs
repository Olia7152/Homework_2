// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int a = new Random().Next(1,1000);
Console.WriteLine($"Рандомное число: {a}");

if (a > 99)
{
    while (a > 1000)
    {
       a = a / 10;
    Console.WriteLine($"Рандомное число в процессе while: {a}"); 
    }
}
else
{
    Console.WriteLine($"Третьей цифры нет: {a}");
}
Console.WriteLine($"Рандомное число в процессе while: {a}");
int result = a % 10;
Console.WriteLine($"Третья цифра рандомного числа: {result}");

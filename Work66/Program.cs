// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите число: ");
Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());

int Summ(int n, int m)
{
    if (n == m) return m;
    return n + Summ(n - 1, m);
}

Console.WriteLine($"Сумма чисел от {m} до {n} ровна {Summ(n, m)}");

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int row = new Random().Next(3,10);
int col = new Random().Next(3,10);
int[] sums = new int[row];
int min = 0;
int sum = 0;
int[,] arr = new int[row, col];
Console.WriteLine($"Задан массив:");
FillArray(arr);
Console.WriteLine();
ArrayStringSum(arr);
int buff = sums[0];
MinString(sums);
Console.WriteLine($"Минимальная сумма элементов в {min + 1} строке");

int[,] FillArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = new Random().Next(0, 100);
            Console.Write($"{a[i, j]} ");
        }
        Console.WriteLine();
    }
    return a;
}

void ArrayStringSum(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < a.GetLength(1); j++)
        {
            sum = sum + a[i, j];
        }
        sums[i] = sum;
    }
}

void MinString(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        if (buff > a[i])
        {
            buff = a[i];
            min = i;
        }
    }
}
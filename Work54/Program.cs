// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int row = new Random().Next(0,10);
int col = new Random().Next(0,10);
int[,] arr = new int[row, col];
Console.WriteLine($"Задан массив:");
FillArray(arr);
Console.WriteLine();
MaxMin(arr);
Console.WriteLine();
PrintArray(arr);

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

int[,] MaxMin(int[,] a)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < a.GetLength(1) - 1; k++)
            {
                if (a[i, k] < a[i, k + 1])
                {
                    int buff = a[i, k + 1];
                    a[i, k + 1] = a[i, k];
                    a[i,k] = buff;
                }
            }
        }
    }
    return a;
}

int[,] PrintArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write($"{a[i, j]} ");
        }
        Console.WriteLine();
    }
    return a;
}
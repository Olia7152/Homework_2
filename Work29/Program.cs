// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] arr1 = new int[8];

for (int i = 0; i < 8; i++)
{
    arr1[i] = new Random().Next(1, 15);
}

string arr = string.Join(", ", arr1);
Console.WriteLine();
Console.Write($"Элементы массива: ");
Console.WriteLine($"{arr} ");
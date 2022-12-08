// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] arr = InitArray(100, 1000);
PrintArray(arr);
Console.WriteLine();
Console.WriteLine($"Количество четных элементов: {num(arr)}");

int[] InitArray(int left, int right)
{
  Console.Write("Введите количество элементов: ");
  int n = Convert.ToInt32(Console.ReadLine());

  int[] array = new int[n];
  for (int i = 0; i < n; i++)
  {
    array[i] = new Random().Next(left, right);
  }
  return array;
}

int num(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i]%2 == 0) count++;
  }
  return count;
}

void PrintArray(int[] array)
{
  Console.Write($"[{array[0]}");
  for (int i = 1; i < array.Length; i++) Console.Write($", {array[i]}");
  Console.Write("]");
} 



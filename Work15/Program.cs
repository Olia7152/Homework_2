// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите индекс дня недели: ");
int a = Convert.ToInt32(Console.ReadLine());

switch (a)
{
    case 1: Console.WriteLine("Понедельник - нет");
    break;
    case 2: Console.WriteLine("Вторник - нет");
    break;
    case 3: Console.WriteLine("Среда - нет");
    break;
    case 4: Console.WriteLine("Четверг - нет");
    break;
    case 5: Console.WriteLine("Пятница - нет");
    break;
    case 6: Console.WriteLine("Суббота - Да! Ура!");
    break;
    case 7: Console.WriteLine("Воскресенье - Да! Ура!");
    break;
    default: Console.WriteLine("Вам нужно отдохнуть!");
    break;
}

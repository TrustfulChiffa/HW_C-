// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Branch task_13

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

Console.Write("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Clear();

if (N < 100) Console.Write($"{N} -> третьей цифры нет");
else
{
    int i = N;
    while (i > 999)
    {
        i /= 10;
    }
    Console.Write($"{N} -> {i % 10}");

}
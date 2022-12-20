// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Branch task_10

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

Console.Write("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Clear();

if (N > 99 & N < 1000)
{
    Console.WriteLine($"{N} -> {(N / 10) % 10}");
}
else Console.WriteLine("Вы ввели не трёхзначное число. Повторите попытку.");
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Branch task_8

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();

Console.Write("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Clear();

int count = 2;

Console.Write($"{N} -> ");

if(N % 2 == 0)
{
    while (count <= N-2)
    {
        Console.Write($"{count}, ");
        count = count + 2;
    }
    Console.Write(N);
}

else
{
    while (count <= N-3)
    {
        Console.Write($"{count}, ");
        count = count + 2;
    }
    Console.Write(N-1);
}
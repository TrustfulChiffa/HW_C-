// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Branch task_2

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();

Console.Write("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Clear();

int max = 0;
int min = 0;

if (a > b) 
{
    max = a;
    min = b;
}

else 
{
    max = b;
    min = a;
}

Console.WriteLine($"a = {a}; b = {b} -> max = {max}");
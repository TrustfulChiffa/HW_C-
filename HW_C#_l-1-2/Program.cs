// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Branch task_15

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

Console.Write("Введите номер для недели ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Clear();

if (N > 7) 
    Console.WriteLine("Вы ввели не номер дня недели. Повторите попытку.");
else
    if (N < 6)
    Console.WriteLine($"{N} -> нет");
    else
    Console.WriteLine($"{N} -> да");
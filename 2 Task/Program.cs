// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

using static System.Console;
Clear();

Write("ВВедите первое число ");
int a = int.Parse(ReadLine());

Write("ВВедите второе число ");
int b = int.Parse(ReadLine());

if (a > b)
{
  WriteLine($"Первое число {a} больше второго числа {b}");
}
else
{
  WriteLine($"Второе число {b} больше первого числа {a}");
}

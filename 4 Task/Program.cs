// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

using static System.Console;
Clear();

Write("ВВедите первое число ");
int a = int.Parse(ReadLine());

Write("ВВедите второе число ");
int b = int.Parse(ReadLine());

Write("ВВедите второе число ");
int c = int.Parse(ReadLine());

if (a > b && a > c)
  {
    WriteLine($"Макcимальное число {a}");
  }

if (b > a && b > c)
  {
    WriteLine($"Макcимальное число {b}");
  }

if (c > a && c > b)
  {
    Write($"Макcимальное число {c}");
  }

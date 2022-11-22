// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

using static System.Console;
Clear();

Write("ВВедите число ");
int a = int.Parse(ReadLine());

int even = a % 2;

if (even == 0){
    WriteLine("Да");
  }

else {
  WriteLine("Нет");
  }

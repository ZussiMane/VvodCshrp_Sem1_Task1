﻿// Напишите программу, которая на вход 
// принимает два целых числа и проверяет, 
// является ли первое число квадратом второго.
// a = 25, b = 5 => да 
// a = 2, b = 10 => нет 
// a = 9, b = -3 => да 
// a = -3, b = 9 => нет

Console.WriteLine("Введите первое число: ");
// string num1str = Console.ReadLine();
int num1 = Convert.ToInt32(Console.ReadLine()); // конвертировали тип "string" в 32-битное число, переменная int занимает в памяти 32 бита(4байта, в каждом байте 8бит=32бита)(диапозон типа данных int 2^32)

Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2 * num2)
{
    Console.WriteLine("Первое число является квадратом втрого числа");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}
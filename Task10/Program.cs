﻿// Задача 10: Напишите программу, 
// которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 & number < 1000)
{
    number = number / 10 % 10;
    Console.WriteLine($"Вторая цифра числа --> {number}");
}
else
{
    Console.WriteLine("Число не трехзначное!");
}

// Задача 13: Напишите программу, 
// которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99)
{
    while (number > 1000)
    {
        number /= 10;
    }
    number %= 10;
    Console.WriteLine($"Третья цифра чилса {number}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
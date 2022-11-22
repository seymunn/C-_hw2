// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.


Console.WriteLine("Введите число:");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 0 & day < 6)
{
    Console.WriteLine("День не выходной");
}
if (day == 6 ^ day == 7)
{
    Console.WriteLine("День выходной");
}
else
{
    Console.WriteLine("Такого дня недели не существует");
}
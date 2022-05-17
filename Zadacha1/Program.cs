/*Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Решение рабочее. Выводы 8+9 можно слепить в один и выводы 13+14 тоже.*/

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA>numberB)
{
    Console.Write("Max=");
    Console.Write(numberA);
}
else
{
    Console.Write("Max=");
    Console.Write(numberB);
}

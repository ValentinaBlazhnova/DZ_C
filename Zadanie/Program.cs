/*Задача 0: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
Решение рабочее. Не хватает проверки на трехзначность.
numberA % 10 - лучше вывести в отдельную переменную.*/

Console.Write("Введите трёхзначное число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(numberA % 10);

/* Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Решение рабочее. Выводы тоже можно слепить.*/ 

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numberС = Convert.ToInt32(Console.ReadLine());
int numberMax = 0;

if (numberA > numberB)
{
    numberMax = numberA;
}
else
{
    numberMax = numberB;
}

if (numberС > numberMax)
{
    numberMax = numberС;
}

Console.Write("Max=");
Console.WriteLine(numberMax);

﻿//Задача 10
//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
//456 -> 5
//782 -> 8
//918 -> 1

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1000 && number > 99)
{
    int second = number % 100;
    int result = second / 10;
    Console.WriteLine($"Вторая цифра введённого числа: {result}");
}
else Console.Write("Вы ввели не трёхзначное число");
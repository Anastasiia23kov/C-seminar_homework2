﻿// Задача 10. Напишите программу, которая принимает на вход трехзначное число
// и на выходе показывает 2-ю цифру этого числа.

Console.Clear();
int n = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число: {n}");
int n2 = (n / 10) % 10;
Console.Write(n2);
﻿// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

int a = new Random().Next(100, 1000);
Console.WriteLine(a);
a = a / 10 % 10;
Console.Write("Second digit of this number is " + a + ".");
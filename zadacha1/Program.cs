﻿//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("ввести трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int newnum = num/10%10;
Console.WriteLine(newnum);

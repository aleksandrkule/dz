// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет.

Console.Write("ввести число");
int num = Convert.ToInt32(Console.ReadLine());
    if (num < 100)
    {
        Console.WriteLine("третьей цифры нет");
    }
    else
    {
        while (num >= 1000)
    {
        num= num/10;
    }
        int num1 = num%10;
        Console.WriteLine(num1);

    }
    
    
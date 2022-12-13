//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.//

Console.Write("ввести пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num/10000;
int num2 = num/1000%10;
int num4 = num/10%10;
int num5 = num%10;
    if(num1==num5 && num2==num4)
    {
        Console.WriteLine("палиндром");
    }
    else
    {
        Console.WriteLine("непалиндром");
    }



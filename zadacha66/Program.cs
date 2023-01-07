// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

int sum(int m, int n)
{
    if (m == n)
      return  n ;
    return sum (m, n - 1) + n;
}

Console.Write("Введите число: ");
 int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sum(m, n));

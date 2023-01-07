// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.


  int accerman(int  m, int  n)
{
    if (m == 0)
        return 1 + n ;
    if  (n == 0 && m > 0)
        return accerman (m - 1, 1);
    else
        return (accerman(m - 1, accerman(m, n - 1)));
}


Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(accerman (m, n));
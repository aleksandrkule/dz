//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void kub(int number)
{
int counter = 1;
while(counter<=number)
{
    Console.Write($"{Math.Pow(counter,3)} ");
counter++;
}
}
Console.WriteLine("ввести число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("куб");
kub(num);

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
void sumnumber(int num)
{
    int sum =0;
while(num>0)
{
    sum = sum+num%10;
    num = num/10;
}
Console.WriteLine(sum);

}
Console.Write("input a number");
int num = Convert.ToInt32(Console.ReadLine());
 sumnumber(num);


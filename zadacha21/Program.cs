//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними
// в 3D пространстве.//
double distance(double xa, double ya, double za, double xb, double yb, double zb)
{
double length = Math.Sqrt(Math.Pow(xb-xa,2)+ Math.Pow(yb-ya,2)+ Math.Pow(zb-za,2));
return Math.Round(length,2);
}
Console.Write("ввести x координату числа a");
double xa = Convert.ToDouble(Console.ReadLine());

Console.Write("ввести y координату числа a");
double ya = Convert.ToDouble(Console.ReadLine());

Console.Write("ввести z координату числа a");
double za = Convert.ToDouble(Console.ReadLine());

Console.Write("ввести x координату числа b");
double xb = Convert.ToDouble(Console.ReadLine());

Console.Write("ввести y координату числа b");
double yb = Convert.ToDouble(Console.ReadLine());

Console.Write("ввести z координату числа b");
double zb = Convert.ToDouble(Console.ReadLine());

double distancebetweenAB = distance(xa,ya,za,xb,yb,zb); 
Console.WriteLine($"distance between points A and B is {distancebetweenAB}.");

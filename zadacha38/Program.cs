//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

void inputarray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 100);
}


void ReleaseArray(double[] array)
{
    double max = array[0], min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i]>max)
        {
            max=array[i];
        }
    
         if (array[i]<min)
         {
            min=array[i]; 
         }
    }
    Console.WriteLine((max-min) + " разницу между максимальным и минимальным элементов массива" );
 
}


Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
inputarray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);
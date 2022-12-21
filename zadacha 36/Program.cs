//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
// стоящих на нечётных позициях.

void inputarray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0,100);
}


void Releasearray (int[] array)
{
    int sum=0;
    for (int i = 1; i < array.Length; i=i+2)
    {
        if (array[i] >0)
        
            sum += array[i];
    }
    
    Console.WriteLine($"сумму элементов, стоящих на нечётных позициях {sum}");
}


Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
inputarray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Releasearray(array);
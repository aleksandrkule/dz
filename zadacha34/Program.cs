//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

void inputarray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}


int ReleaseArray(int[] array)
{
    int count=0   ;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] %2 ==0)
            count ++;
    }
     return count ;
}
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n]; 
inputarray (array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleaseArray(array);
Console.WriteLine($"result: {ReleaseArray(array)}");



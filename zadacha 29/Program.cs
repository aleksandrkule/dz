//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    Console.Write("ввести элемент массива");
    int x = Convert.ToInt32(Console.ReadLine());
    array[i] = x;
}
Console.WriteLine($"[{string.Join(",",array)}]");

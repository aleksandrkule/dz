//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

  Console.Write("Введите число A ");
  int A = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B ");
  int B = Convert.ToInt32(Console.ReadLine());
  int result = 1;
  int [] array = new int [B];
  for (int i = 0; i <array.Length; i++)
  {
    array[i] = A;
  }
  for (int j = 0; j < array.Length; j++)
  {
    result*=array[j];
  }
  Console.WriteLine(result);



 


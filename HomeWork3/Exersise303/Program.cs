﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine("Start");
Console.Write("Введите число: ");
int cube = Convert.ToInt32(Console.ReadLine());
void Cube(int[] cube)
{
  int counter = 1;
  int length = cube.Length;
  while (counter <  length)
  {
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}
void PrintArray(int[] coll)
{
  int count = coll.Length;
  int index = 1;
  while(index < count)
  {
    Console.WriteLine(coll[index]+ " ");
    index++;
  }
} 
int[] array = new int[cube+1];
Cube(array);
PrintArray(array);



Console.WriteLine($"Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
Console.Write("Введите колличество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] position = new int[m, n];
void FillArray2DRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-50, 50);
        }
    }
}
void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
void ReturnValueElement(int[,] matrix)
{
    int valueElement = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            valueElement = matrix[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
        }
    }
    Console.Write(valueElement);
}
FillArray2DRandomNumbers(position);
PrintArray2D(position);
ReturnValueElement(position);



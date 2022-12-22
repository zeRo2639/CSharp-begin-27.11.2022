public static class Exersise502
{
    public static void Task36()
    {
        int [] array = Methods.CreateArray(5);
        Methods.Fill(array);
        Methods.SumOddNumbers(array);
        Methods.PrintArray(array);
        Console.WriteLine();
        int sum = Methods.SumOddNumbers(array);
        Console.WriteLine($"Сумма нечетных чисел в массиве: {sum}");
    }
}

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
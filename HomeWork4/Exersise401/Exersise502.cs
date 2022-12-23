public static class Exersise502
{
    // Задача 36: Задайте одномерный массив, заполненный случайными числами. 
    // Найдите сумму элементов, стоящих на нечётных позициях.
    public static void Task36()
    {
        int [] array = Methods.CreateArray(5);
        Methods.FillArray(array, -10, 20);
        Methods.SumOddNumbers(array);
        Methods.PrintArray(array);
        Console.WriteLine();
        int sum = Methods.SumOddNumbers(array);
        Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях в массиве равна: {sum}");
    }
}
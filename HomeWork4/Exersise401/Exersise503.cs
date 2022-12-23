public static class Exersise503
{
//Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

    public static void Task38()
    {
        double [] array = Methods.CreateArrayRealNumbers(4);
        Methods.FillArrayRealNumbers(array, 1, 5);
        Methods.PrintArrayRealNumbers(array);
        Console.WriteLine();
        double decision = Methods.RealNumbers(array);
        Console.WriteLine($"Разница между максимальным и минимальным элементами равна: {decision}");
    }
}
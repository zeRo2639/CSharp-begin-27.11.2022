public static class Exersise501
{
        public static void Task34()
        {
        int [] array = new int[10]; 
        Methods.FillArray(array, 100, 1000);
        Methods.EvenNumbers(array);
        Methods.PrintArray(array);
        Console.WriteLine();
        int even = Methods.EvenNumbers(array);
        Console.WriteLine($"Количество чётных чисел в массиве: {even}");
        }
}



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


// "cSpell.language": "en,ru"

public static class Exersise501
{
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
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


// "cSpell.language": "en,ru"

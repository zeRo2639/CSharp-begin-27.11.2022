public static class Exersise403
{
    static public void Task29()
    {
       int[] massive = Methods.CreateArray(5);
       Methods.Fill(massive);
       int dec = Methods.ToDec(massive);
       Console.WriteLine($"{Methods.Print(massive)} ==> {dec}");
    }
}

// Напишите программу, которая задаёт массив из N элементов (из диапазона [0-14] ) и выводит на экран десятичное представление числа, 
// записанного в СС по основанию 15
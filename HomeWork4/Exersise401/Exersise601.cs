// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 0, 7, 8, -2, -2 -> 2 // 1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел М: "); // Поросим пользователя ввести количество чисел для создания массива
int m = Convert.ToInt32(Console.ReadLine()); // Конвертируем заданное число в значеие int 
int[] size = new int[m]; // Создаем массив из количества чисел введенных пользователем

void InputNumbers(int m) // Создаем метод для ручного ввода чисел
{
    for (int i = 0; i < m; i++)  // i - счетчик введеннных чисел; i < m - диапазон ввода чисел, т.е. количество вводимых чисел пользователем не должно превышать уже заданного допустимого количества чисел в массиве   
    {
        Console.Write($"Введите число {i + 1}: ");
        size[i] = Convert.ToInt32(Console.ReadLine());
    }
}
int Sravni(int[] size)
{
    int Numbers = 0;
    for (int i = 0; i < size.Length; i++) 
    { 
        if (size[i] > 0) Numbers++;
    }
    return Numbers;
}
InputNumbers(m);
Console.WriteLine($"Введено чисел больше нуля {Sravni(size)}: ");
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
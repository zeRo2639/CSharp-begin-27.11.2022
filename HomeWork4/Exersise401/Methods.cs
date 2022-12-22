public static class Methods
{
    // Создание массива
    public static int[] CreateArray(int count)
    {
        return new int[count];
    }

    // Заполнение массива
    public static void Fill(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Shared.Next(1, 10);
        }
    }
   
    // Метод заполнения массива min max
    public static void FillArray(int[] array, int min, int max)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(min, max);
        }
    }
    
    // Печать массива для стринга
    public static string Print(int[] array)
    {
        return String.Join(' ', array);
    }
    
    // Печать численного массива 
    public static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
    
    // написать конвертор из 15-ой в 10-ую 
    // [6,4,3,10]
    //  3 2 1  0 - индексы чисел в математике справа на лево
    //  0 1 2  3 - индексы значений элемента в массиве слева направо
    // 10 * 15^0 + 3 * 15^1 + 4 * 15^2 + 6 * 15^3
    public static int ToDec(int[] value)
    {
        int result = 0;
        int count = value.Length;
        for (int i = 0; i < value.Length; i++)
        {
            result += value[i] * Pow(15, count - 1 - i);
        }
        return result;
    }

    // Напишите цикл, который возводит число A в натуральную степень B. 
    public static int Pow(int a, int b)
    {
        int result = 1;
        for (int i = 0; i < b; i++)
        {
            result = result * a;
        }
        return result;
    }

    // написать программу, которая принимает на вход число и выдаёт сумму цифр в числе.
    // 452 -> 11 82 -> 10 9012 -> 12
    public static int SumNumberIn(int value)
    {
        int Number = 0;
        while (value != 0)
        {
            Number += value % 10;
            value = value / 10;
        }
        return Number;
    }

    // метод вывода количества чётных чисел в массиве.
    public static int EvenNumbers(int[] array)
    {
        int even = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 1)
            {
                even++;
            }
        }
        return even;
    }
    
    // методод вывода количества нечетных чисел в массиве
    public static int OddNumbers(int[] array)
    {
        int odd = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                odd++;
            }
        }
        return odd;
    }
   
    // метод вывода суммы элементов массива, стоящих на нечетных позициях
    public static int SumOddNumbers(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 1)
            {
                sum = sum + array[i];
            }
        }
        return sum;
    }
   
    // метод вывода суммы элементов массива, стоящих на четных позициях
    public static int SumEvenNumbers(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 == 0)
            {
                sum = sum + array[i];
            }
        }
        return sum;
    }
}





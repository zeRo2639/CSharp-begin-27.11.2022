// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Start");
Console.WriteLine("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int a = n/10000, b = n%10, c = (n/1000)%10, d = (n%100)/10;
    if (a == b && c == d)
    {
        Console.WriteLine("данное число палиндром");
    }
    else 
    {
        Console.WriteLine("не палиндром");
    }
Console.WriteLine("End");
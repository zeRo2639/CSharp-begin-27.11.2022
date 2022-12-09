// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5 78 -> третьей цифры нет 32679 -> 6
Console.WriteLine("Start");
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
        if (a < 100)
            {
            Console.WriteLine("третьей цифры нет");
            }
        if (a > 100)
        {
            Console.WriteLine((a / 10) % 10);// через деление разбивае трехзначное число по цифрам и получаем вторую цифру
            Console.WriteLine("End");
        }
    
 
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве. 
// A (0,0); B (1,1), -> ~1.4
// A (2,4); B (0,7) -> ~3.6
Console.WriteLine("Start");
int x1 = 2;
int y1 = 4;
int x2 = 0;
int y2 = 7;
double distance = 0;
distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine($"Расстояние между двумя точками равно {distance}");

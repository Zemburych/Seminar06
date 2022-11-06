// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// 0=k1*x+b1-K2*x-b2
// 0=x(k1-k2)+b1-b2
// x(k1-k2)=b2-b1
// x=(b2-b1)/(k1-k2)

Console.Clear();
Console.Write("Ввелите число b1 - ");
double b1 = int.Parse(Console.ReadLine());
Console.Write("Ввелите число k1 - ");
double k1 = int.Parse(Console.ReadLine());
Console.Write("Ввелите число b2 - ");
double b2 = int.Parse(Console.ReadLine());
Console.Write("Ввелите число k2 - ");
double k2 = int.Parse(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Пересечение в точке: ({x};{y})");

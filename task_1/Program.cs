/* Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

void degree (double i, double n)
{
double ans = Math.Pow (i,n);

Console.Write($"{i} ");
Console.Write($"в степени {n} ");
Console.Write($"= {ans}");
}

Console.WriteLine("Введите первое число: ");
double A = double.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
double B = double.Parse(Console.ReadLine());

degree (A,B);
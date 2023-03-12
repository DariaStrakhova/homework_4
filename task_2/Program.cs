/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

void sumdigit (int n)
{
    int sum = 0;
    int x = 0;
    while(n > 0)
{
    x = n % 10;
    sum = sum + x;
    n = n/10;
}
Console.Write($"Сумма чисел: {sum}");
}   
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

sumdigit (number);

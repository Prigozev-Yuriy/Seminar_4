// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using System.Globalization;

// Вариант решения №1:
Console.Write("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int variable = 0; //переменная для цикла
while (variable <= A)
{
    int product = 1;
    for (int i = 1; i <= B; i++)
    {
        product = product * variable;
    }
    if (variable == A)
    {
        Console.WriteLine($"Число {A} в степини {B} равно: {product}");
    }
    variable++;
}



// Вариант решения №2:
// Console.Write("Введите число А: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int B = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Число {A} в степини {B} равно: {Math.Pow(A, B)}");
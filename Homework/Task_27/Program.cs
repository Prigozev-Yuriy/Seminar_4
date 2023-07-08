// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int CopyNumber = number;
int sum = 0;
while (CopyNumber > 0)
{
    sum = sum + CopyNumber % 10;
    CopyNumber = CopyNumber / 10;
}
Console.Write($"Сумма цифр в числе {number} равна: {sum}");
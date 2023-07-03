// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.Write("Введите число: ");
// int limit = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i=1; i<= limit; i++)
// {
//     sum += i;
// }
// Console.WriteLine($"Сумма чисел от 1 до {limit} = {sum}");


// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// int copyNumber = number;
// if (number != 0)
// {
//     while (number > 0)
//     {
//         count++;
//         number /= 10; //number = number/10
//     }
// }
// else
// {
//     count++$
// }
// Console.WriteLine($"В числе {copyNumber}: {count} цифр(ы)");

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120



// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int size = 8;
int [] array = new int [size];
for (int i = 0; i<array.Length; i++)
{
    array [i] = new Random().Next(2);
}
Console.WriteLine ($"Массив: [ {string.Join("; ", array)} ]");
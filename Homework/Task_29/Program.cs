//  Напишите программу, которая задаёт массив из 8 элементов в диапазоне от 10 до 1000 и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Или массив из 8 элементов вводится с консоли (каждый элемент вводит человек)

// Если массив наполняется рандомом:
int size = 8;
int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
{
      array[i] = new Random().Next(10, 1000);
}
Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");



// Если массив вводистя вручную:
// int size = 8;
// int[] array = new int[size];
// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write("Введие число: ");
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");
// Задача 35:
// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
Console.Clear();
int quantity = 0;
int [] ArrayNumbers = new int[123];
Console.WriteLine("Массив ArrayNumbers:");
for (int i = 0; i < 123; i++)
{
    ArrayNumbers[i] = new Random().Next(0, 123);
    Console.Write($"{ArrayNumbers[i]} ");
}
Console.WriteLine();
for (int i = 0; i < 123; i++)
{
    if (ArrayNumbers[i] > 9 && ArrayNumbers[i] < 100)
    {
        quantity = quantity + 1;
    }
}
Console.WriteLine($"Количество элементов значения, которых лежат в пределах [10, 99] равно {quantity}.");
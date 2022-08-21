// Задача 32:
// Напишите программу замены элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
Console.Clear();
int[] ArrayNumbers = new int[10];
Console.Write("Исходный массив: ");
for (int i = 0; i < 10; i++)
{
    ArrayNumbers[i] = new Random().Next(-10, 10);
    Console.Write($"{ArrayNumbers[i]} ");
}
Console.WriteLine();
Console.Write("Модифицированный массив: ");
for (int i = 0; i < 10; i++)
{
    ArrayNumbers[i] = ArrayNumbers[i] * -1;
    Console.Write($"{ArrayNumbers[i]} ");
}
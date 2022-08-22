// Задача 37:
// Найдите произведение пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
Console.Write("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
if (length > 2)
{
int lengthNew = length/2 + length % 2;
int[] ArrayNumbersNew = new int[lengthNew];
int[] ArrayNumbers = new int[length];
Console.Write("Массив ArrayNumbers:");
for (int i = 0; i < length; i++)
{
    ArrayNumbers[i] = new Random().Next(0, 20);
    Console.Write($" {ArrayNumbers[i]}");
}
lengthNew = length/2 + length % 2;
Console.WriteLine();
Console.WriteLine($"Длина нового массива: {lengthNew}.");
Console.Write("Новый массив ArrayNumbersNew:");
if (length % 2 < 1)
{
    for (int i = 0; i < lengthNew; i++)
    {
        ArrayNumbersNew[i] = ArrayNumbers[i] * ArrayNumbers[(length - (i + 1))];
        Console.Write($" {ArrayNumbersNew[i]}");
    }
}        
else
{
    for (int i = 0; i < (lengthNew - 1); i++)
    {
        ArrayNumbersNew[i] = ArrayNumbers[i] * ArrayNumbers[(length - (i + 1))];
        Console.Write($" {ArrayNumbersNew[i]}");
        
    }
    ArrayNumbersNew[lengthNew - 1] = ArrayNumbers[lengthNew - 1];
    Console.Write($" {ArrayNumbersNew[lengthNew - 1]}");
} 
}
else
{
    Console.WriteLine("Введена неверная длина массива.");
}
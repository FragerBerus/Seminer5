// Задача 31:
// Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.
Console.Clear();
int Pozitive = 0;
int Negative = 0;
int[] ArrayNumbers = new int[19];
for (int i = 0; i < 18; i++)
{
    ArrayNumbers[i] = new Random().Next(-9, 9);
}
Console.WriteLine("Cостав массива ArrayNumbers:");
for (int i = 0; i < 18; i++)
{
    if (ArrayNumbers[i] < 0)
    {
        Negative = Negative + ArrayNumbers[i];
    }
    else
    {
        Pozitive = Pozitive + ArrayNumbers[i];
    }
    Console.Write($"{ArrayNumbers[i]} ");
}
Console.WriteLine();
Console.WriteLine($"Сумма отрицательных чисел массива равна {Negative}.");
Console.WriteLine($"Сумма положительных чисел массива равна {Pozitive}.");
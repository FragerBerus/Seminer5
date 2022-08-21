// Задача 33:
// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
Console.Clear();
int count = 0;
int [] ArrayNumbers = new int [5];
Console.Write("Массив ArrayNumbers:");
for (int i = 0; i < 5; i++)
{
    ArrayNumbers[i] = new Random().Next(-9, 9);
    Console.Write($" {ArrayNumbers[i]}");
}
Console.WriteLine("");
Console.Write("Введите любое однозначное целое число: ");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number > -9 && Number < 9)
{
    for (int i = 0; i < 5; i++)
    {
        if (Number == ArrayNumbers[i])
        {
            Console.WriteLine($"Число {Number} присутствует в массиве ArrayNumbers.");
            count = 1;
            break;
        }
    }
}
else
{
    Console.WriteLine("Введенное значение не соответствует условию задачи!!!");
    count = 1;
}
if (count == 0) {Console.WriteLine($"Число {Number} отсутствует в массиве ArrayNumbers.");}
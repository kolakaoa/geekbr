﻿/*
Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементами массива.
[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
*/


Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
        {
            max = numbers[z];
        }
    if (numbers[z] < min)
        {
            min = numbers[z];
        }
}

Console.WriteLine($"Всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}

void PrintArray(double[] numbers)
{
    Console.Write("[");
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i < numbers.Length - 1) Console.Write($"{numbers[i]},");
    }
    Console.Write(numbers[numbers.Length - 1]);
    Console.Write("]");
}
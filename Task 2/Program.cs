﻿Console.Write("Введите первое целое число: " );
var number1 = Decimal.Parse(Console.ReadLine());
Console.Write("Введите второе целое число: " );
var number2 = Decimal.Parse(Console.ReadLine());

if(number1 > number2) 
{
Console.Write($"максимальное число {number1} ");
}
else if(number1 < number2)
{
Console.Write($"Mаксимальное число {number2} ");
}
else
{
Console.Write("Числа равны! ");
}
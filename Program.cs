/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
  значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.WriteLine("Введите значение b1 :   ");
Double numberb1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение k1 :   ");
Double numberk1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение b2 :   ");
Double numberb2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значение k2 :   ");
Double numberk2 = Convert.ToDouble(Console.ReadLine());

// Пишем уравниния
/*
y = k1 * x + b1,
y = k2 * x + b2;
k1 * x + b1=k2 * x + b2
k1 * x - k2 * x = b2 - b1
(k1 + k2) * x =  b2 - b1
( b2 - b1)/(k1 - k2) = x   */

var x = ( numberb2 - numberb1)/(numberk1 - numberk2);

Console.WriteLine($" Значение х = { x }");

var y = numberk1 * x + numberb1;
Console.WriteLine($" Значение у = { y }");
Console.WriteLine($" Точка пересечения прямых ({ x } ; { y } )");


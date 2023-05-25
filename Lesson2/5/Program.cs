// See https://aka.ms/new-console-template for more information
/// 16 Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет
Console.Clear();
System.Console.WriteLine("Введите два числа");
int Number1 = int.Parse(Console.ReadLine());
int Number2 = int.Parse(Console.ReadLine());
if ( Number1==Number2*Number2 || Number2==Number1*Number1) //Math.Pow(Number2,2)==Number1
System.Console.WriteLine("Да");
else 
Console.WriteLine("Нет");

// See https://aka.ms/new-console-template for more information
// /11 Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.
Console.Clear();
int Num = new Random().Next(100,1000);
int Num1 = Num % 10;
int Num2 = Num / 100;
int Num3 = Num2*10+Num1;
Console.WriteLine($"Было {Num} стало - {Num3}");

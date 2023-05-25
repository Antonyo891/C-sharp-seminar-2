// See https://aka.ms/new-console-template for more information
//// **Задача 14:**

// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.
//if((a > b || a < c) && (x > b || x < c) || d == 5))
// 0 + 0 1 + 0
// 0 * 1
// 0 + 1
// 1
// 14 -> нет
// 46 -> нет
// 161 -> 
Console.Clear();
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());
int a=7, b=23;
if ((num%7==0) && (num%23==0))
Console.WriteLine($"Число {num} кратно 7 и 23");
else
{
    Console.WriteLine($"Число {num} некратно 7 и 23");
}

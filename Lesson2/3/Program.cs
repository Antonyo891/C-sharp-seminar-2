// See https://aka.ms/new-console-template for more information
/*12 Напишите программу, которая будет принимать на вход два числа и выводить,
является ли второе число кратным первому. Если второе число не кратно числу первому,
то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
*/
Console.Clear();
Console.WriteLine("Введите число №1");
int Num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число №2");
int Num2 = int.Parse(Console.ReadLine());
if (Num2%Num1==0)
Console.WriteLine($"Число {Num2} кратно {Num1}");
else
Console.WriteLine($"Число {Num2} некратно {Num1}. Остаток от деления - {Num2%Num1}");

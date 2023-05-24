// See https://aka.ms/new-console-template for more information
// создает рандомное число, от 10 до 99 и показывает какая цифра в нем макисмальная
Console.Clear();
int Number = new Random().Next(10,100);
int Number1 = Number / 10;
int Number2 = Number % 10;
int Max = Number1;
if (Number2>Number1) 
Max = Number2; 
Console.WriteLine($"В числе {Number} максимальная цифра {Max}");

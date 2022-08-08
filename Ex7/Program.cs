//Задача 7: Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

int last_digit = number%10;
Console.WriteLine($"Последняя цифра числа - {last_digit}");

//Задача 4: Напишите программу, которая принимает на вход три числа
//и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число:");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int number_3 = Convert.ToInt32(Console.ReadLine());

int [] array = { number_1, number_2, number_3 };
int max_number = array.Max();
Console.WriteLine($"Максимальное число - {max_number}");

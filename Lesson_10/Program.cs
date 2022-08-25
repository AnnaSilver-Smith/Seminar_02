//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трехзначное число: ");
string str = Convert.ToString(Convert.ToInt32(Console.ReadLine()));
Console.WriteLine(str[1]);
//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Ввести номер дня недели: ");
int DayOfWeek = Convert.ToInt32(Console.ReadLine());
if ((DayOfWeek == 6) || (DayOfWeek == 7))
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Будний день");
}
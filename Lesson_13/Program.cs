//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");
String str = Convert.ToString(Convert.ToInt32(Console.ReadLine()));
if ( str.Length > 2)
{
    Console.WriteLine(str[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет, повторите попытку.");
}
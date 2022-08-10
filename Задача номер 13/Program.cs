// Напишите программу, которая выводит третью цифру заданного
// числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// Решение:
Console.Write("Введи число: ");
int Number = Convert.ToInt32(Console.ReadLine());
string number = Convert.ToString(Number);
if (number.Length > 2)
{
    Console.WriteLine("третья цифра " + number[2]);
}
else
{
    Console.WriteLine("третьей цифры нет ");
}
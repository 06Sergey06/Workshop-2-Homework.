// Напишите программу, которая принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
// Решение:
Console.Write("Введите цифру, обозначающую день недели: ");
int deyNumber = Convert.ToInt32(Console.ReadLine());
if (deyNumber == 1)
{
    Console.WriteLine("Первый день не является выходным днем");
}
if (deyNumber == 2)
{
    Console.WriteLine("Второй день не является выходным днем");
}
if (deyNumber == 3)
{
    Console.WriteLine("Третий день не является выходным днем");
}
if (deyNumber == 4)
{
    Console.WriteLine("Четвертый день не является выходным днем");
}
if (deyNumber == 5)
{
    Console.WriteLine("Пятый день не является выходным днем");
}
if (deyNumber == 6)
{
    Console.WriteLine("Шестой день является выходным днем");
}
if (deyNumber == 7)
{
    Console.WriteLine("Седьмой день является выходным днем");
}
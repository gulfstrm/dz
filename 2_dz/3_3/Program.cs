﻿// Напиши программу которая выводит третью цифру
// заданного числа или сообщает что третьей цифры нет.


Console.Write("Ведите число: ");

int n = Convert.ToInt32(Console.ReadLine());

if (n < 100)

    Console.WriteLine("Третьей цифры нет ");

while (n > 999)
{
    n = (n / 10);
}
if(n>100)
Console.WriteLine($"Третье число {n % 10}");

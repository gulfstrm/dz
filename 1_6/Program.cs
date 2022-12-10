// Напишите программу ,которая принимаетна вход три числа и выдает
// максимальное из этих чисел.
Console.WriteLine("Введите число  1");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число  2");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число  3");
int c = Convert.ToInt32(Console.ReadLine());

int maximal = a;

if (a > maximal) maximal = a;
if (b > maximal) maximal = b;
if (c > maximal) maximal = c;

Console.WriteLine(" самое большое число: " + maximal);

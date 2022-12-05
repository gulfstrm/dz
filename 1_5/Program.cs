// Напишите программу, которая на вход принимает два числа и выдает
// , какое число большее , а какое меньшее.

Console.Write("Введите число");

int a = Convert.ToInt32(Console.ReadLine());

int b = Convert.ToInt32(Console.ReadLine());


if(a>b)
{
      Console.WriteLine(a);
}
else
Console.WriteLine(b);
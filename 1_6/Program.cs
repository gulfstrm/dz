// Напишите программу ,которая принимаетна вход три числа и выдает
// максимальное из этих чисел.
Console.WriteLine("Введите число  1");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число  2");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число  3");
int c = Convert.ToInt32(Console.ReadLine());

if(a>b)
{
    Console.WriteLine(a);
}

else if(a>c)
{
    Console.WriteLine(a);
}
else if(b>c)
{
    Console.WriteLine(b);
}
else 
Console.WriteLine(c);
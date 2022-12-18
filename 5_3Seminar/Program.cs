// Напиши прог которая принимает на вход три числа и проверяет
// может ли сушествовать треугольник со сторонами такой длины.

void TryG()
{
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());

    if (a < b+c & b < a + c & c < a + b)
    Console.WriteLine(" Yes");
    else
    Console.WriteLine("no");
}
TryG();
// Напиши программу ,которая на вход принимает число и выдает , 
// является ли число четным(делиться ли оно на два без остатка).
Console.WriteLine("Введите число  ");

int num = int.Parse(Console.ReadLine());

if(num % 2 == 0)
{
Console.WriteLine("да");
}
else
Console.WriteLine("нет");
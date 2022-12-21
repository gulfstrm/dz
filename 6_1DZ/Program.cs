// Пользователь вводит с клавиатуры M чисел.
// Посчитай сколько чисел больше O ввел пользователь.

int Check(int num)
{
    int count = 0;
    for (int i = 1; i <= num; i++)
{
    Console.Write($"Число {i}: ");
    int  a = int.Parse(Console.ReadLine());
    if (a > 0) count++;
}
return count;
}
Console.Write("Сколько чисел хотите вставить?: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine($"Колличество чисел больше 0: {Check(a)}");

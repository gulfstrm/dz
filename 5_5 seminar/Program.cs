// неиспользую рекурсию выведи первые n число Фибонначи.
// Первые два числа Фибонначи : 0 и 1.
void Fibbonacci (int num)
{
    int a = 0, b = 1;
    for (int i = 0; i < num; i++)
    {
        Console.Write($"{a} ");
        (a,b) = (b,a + b);
    }
}
int num = int.Parse(Console.ReadLine());
Fibbonacci(num);
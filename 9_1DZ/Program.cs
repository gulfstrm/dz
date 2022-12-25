// Задай значение M и N .Напиши прог котрая выведет все четные
// натуральные числа в промежутке от M до N  с помощью рекурсии.

void Numbers(int m, int n)
{
    if (m > n) return;
    if(m % 2 == 0)
    Console.Write($"{m}  ");
    Numbers(m + 1, n);

}
Numbers(4, 8);
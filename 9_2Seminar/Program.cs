// Задай значение M и N .Напиши прог которая рекрсивно
// выведет все натур числа в промежутке от m до n.

void Numbers(int m,int n)
{
    if(m > n) return;
    Console.Write($"{m} ");
    Numbers(m + 1,n);
}
Numbers(5,8);
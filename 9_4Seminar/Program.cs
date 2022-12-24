// Напиши прогкотрая на вход принимает два числа A и B 
 // и возводит число A  в целую степень B с помощью рекурсии.

int Degree ( int a,int b)
{
    if (b == 0) return 1;
    return Degree (a, b - 1) * a;
}
Console.WriteLine((Degree(3,5)));
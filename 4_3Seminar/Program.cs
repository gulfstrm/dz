// напиши прог которая принимает на вход число n и выдает
// произведение чисел о  1 до n.

int Proiz(int num)
{
    int all_sum = 1;
    for (int i = 1; i <= num; i++)
    {
        all_sum = all_sum * i;
    }
    return all_sum;
}
Console.WriteLine(Proiz(int.Parse(Console.ReadLine())));
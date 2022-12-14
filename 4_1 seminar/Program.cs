// Напишите программу которая принимает на вход число (а) и 
//выдает сумму чисел от 1 до а.

int SumNums(int num)
{
    int all_sum = 0;
    for (int i = 1; i <= num; i++)
    {
        all_sum += i;
    }

    return all_sum;
}

Console.WriteLine(SumNums(int.Parse(Console.ReadLine())));

int i = 0;
i++;
i += 1;
i = i + 1;


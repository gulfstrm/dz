﻿// Нпапиши прог замена элементов массива: положительные элементы замените
// на соответствующие отрицательные и наоборот.

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] Mass(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(-100, 100);
    return arr;
}

string Poisk(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(num == arr[i])
        return "yes";
    }
    return "no";
}

int[] arr_1 = Mass(int.Parse(Console.ReadLine()));
Print(arr_1);
Console.WriteLine(Poisk(arr_1,int.Parse(Console.ReadLine())));
// Напиши прог которая на вход принимает позиции элементов в двухмерном массиве  и 
// возвращает значение этого элемента или указание что такое элемент.


void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($"{arr[i, j]}");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);

    return arr;
}


string FindElement(int[,] arr, int f, int s)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    if (f > row || f <= 0 || s > column || s <= 0)
        return $"{f} {s} -> not in the array";
    return $"arr[{f} ,{s}] = {arr[f - 1, s - 1]} -> is in the array ";
}


Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of column: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column,
int.Parse(Console.ReadLine()),
int.Parse(Console.ReadLine()));
Print(arr_1);

Console.Write("Enter the line posicion:");
int first = int.Parse(Console.ReadLine());
Console.Write("Enter the column posicion:");
int sekond = int.Parse(Console.ReadLine());

Console.WriteLine(FindElement(arr_1,first,sekond));
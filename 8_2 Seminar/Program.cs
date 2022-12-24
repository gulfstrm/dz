// Задай двух мернный массив.Напиши прог которая заменяет строки на столбцах
// В случае если не возможно прог должна вывести сооб для пользователя.

void Print(double[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($"{arr[i, j],6}");
        Console.WriteLine();
    }
    Console.WriteLine();
}
double[,] MassNums(int row, int column, int from, int to)
{
    double[,] arr = new double[row, column];
    Random n_new = new Random();

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = Math.Round(n_new.NextDouble() * -10, 2);
    return arr;
}

void ChangeUp(double[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    if (row == column)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < i; j++)
            {
                (arr[i, j], arr[j, i]) = (arr[j, i], arr[i, j]);
            }
            Console.WriteLine();
        }
    }
    else
    {
        Console.WriteLine("Замена невозможно");
    }
}
double[,] arr1 = MassNums(int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()));


Print(arr1);
ChangeUp(arr1);
Print(arr1);
// Задай 2 мерный массив размер m на n каждый элемент
// в массиве находиться по формуле :A[][]  = m+n.
// выведите полученный массив на экран.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($"{arr[i, j],4}");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] MassNums(int row, int column)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = i + j;

    return arr;
}
Console.WriteLine("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the number of column: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column);
Print(arr_1);
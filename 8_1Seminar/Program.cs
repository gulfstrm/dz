// Задай двухмерный массив.Напиши прог которая поменяет местами первую и последнюю строку масива.



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
            arr[i, j] = Convert.ToDouble(new Random().Next(-100, 100) / 10.0);
    return arr;
}

Console.WriteLine("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the number of column: ");
int column = int.Parse(Console.ReadLine());

double[,] arr_1 = MassNums(row, column,
                           int.Parse(Console.ReadLine()),
                           int.Parse(Console.ReadLine()));
Print(arr_1);


void NewStr(double[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    for (int i = 0; i < column; i++) 
    (arr[0, i], arr[row - 1, i]) = (arr[row - 1, i], arr[0, i]);
}

NewStr(arr_1);
Print(arr_1);

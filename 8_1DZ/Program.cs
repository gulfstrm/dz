// Задай двухмерный массив.Напиши прог которая упорядочит 
//по убыванию элементы каждой строки  двухмерного массива.


void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($"{arr[i, j],3}");
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

void OrderElMin(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            for (int k = 0; k < column_size - j - 1; k++)
                if (arr[i, k] < arr[i, k + 1])
                    (arr[i, k], arr[i, k + 1]) = (arr[i, k + 1], arr[i, k]);
        }
    }
}


Console.Write("enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("enter the number of colums: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));

Console.Write("Enter the line posicion:");
int first = int.Parse(Console.ReadLine());
Console.Write("Enter the column posicion:");
int sekond = int.Parse(Console.ReadLine());



Print(arr_1);
OrderElMin(arr_1);








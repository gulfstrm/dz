// Задай две матрицы .Напиши прог которая будет находить
// произведение двух матриц.


void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($"{arr[i, j],3} ");
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

 int[,]MatrixProduct(int[,] arr_first, int[,] arr_sekond)
{
    int row_size= arr_first.GetLength(0);
    int column_size = arr_first.GetLength(1);
    int[,] pr_matrix = new int[row_size,column_size];

    if(row_size != arr_sekond.GetLength(0) || column_size != arr_sekond.GetLength(1)) return pr_matrix;
    {
    for (int i = 0; i < row_size; i++)
       for (int j = 0; j < row_size; j++)
       pr_matrix[i,j] = arr_first[i,j] * arr_sekond[i,j];
       return pr_matrix;
}


}
Console.Write("enter the number of rows 1: ");
int row_1 = int.Parse(Console.ReadLine());
Console.Write("enter the number of colums 1: ");
int column_1 = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row_1, column_1,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(arr_1);



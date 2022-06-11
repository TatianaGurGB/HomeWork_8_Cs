// Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

void PrintArray(int[,] matr)
{
    int row_size = matr.GetLength(0);
    int column_size = matr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {matr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] FillArray(int row, int column, int from, int to)
{
    int[,] matr = new int[row, column];
    
    for (int i = 0; i < row; i++)
        
        for (int j = 0; j < column; j++)
            matr[i, j] = new Random().Next(from,to);      
    return matr;                                     
}    

int[,] Matrix(int[,] matr1, int[,] matr2)
{
    int row_size = matr1.GetLength(0);
    int column_size = matr1.GetLength(1);
    int row_size = matr2.GetLength(0);
    int column_size = matr2.GetLength(1);
    int[,] new_matrix = new int[row_size, column_size];

    for (int i = 0; i < row_size; i++)       
        for (int j = 0; j < column_size; j++)
            new_matrix[i, j] = matr1[i, j] * matr2[i, j];            
    return new_matrix;
}

Console.Write("Enter row: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter column: ");
int column = int.Parse(Console.ReadLine());
int[,] matr = FillArray(row, column, 0, 10);
PrintArray(matr);
Matrix(matr1,matr2);

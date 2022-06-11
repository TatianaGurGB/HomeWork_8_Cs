// Задайте двумерный массив. Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.

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

void MinElement(int[,] matr)
{
    int row_size = matr.GetLength(0);
    int column_size = matr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            for (int el = 0; el < column_size - j - 1; el++)
                if (matr[i, el] < matr[i, el + 1])
                    (matr[i, el], matr[i, el + 1]) = (matr[i, el + 1], matr[i, el]);
        }
    }
}


Console.Write("Enter row: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter column: ");
int column = int.Parse(Console.ReadLine());
int[,] matr = FillArray(row, column, 0, 10);
PrintArray(matr);
MinElement(matr);
PrintArray(matr);


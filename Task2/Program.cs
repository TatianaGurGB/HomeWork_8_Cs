// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

void MinSumElement(int[,] matr)
{
    int row_size = matr.GetLength(0);
    int column_size = matr.GetLength(1);
    int counter = 1000;
    int min = 0;
    int num = 0;

    for (int i = 0; i < row_size; i++)
    {   
        int num = 0;
        for (int j = 0; j < column_size; j++)
            num += matr[i, j];
           
        if (counter > num)
        {
            counter = num;
            min = i;
        }
    }
    Console.Write($"Min sum in row - {min + 1}");
}

Console.Write("Enter row: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter column: ");
int column = int.Parse(Console.ReadLine());
int[,] matr = FillArray(row, column, 0, 10);
PrintArray(matr);
MinSumElement(matr);

//создание и вывод на консоль  двухмерного массива [3, 5];

int[,] metrix = new int[3, 5];

Random rnd = new Random();
for (int i = 0; i < metrix.GetLength(0); i++)
{
    for (int j = 0; j < metrix.GetLength(1); j++)
    {
        metrix[i, j] = rnd.Next(1, 11);
    }

}

for (int i = 0; i < metrix.GetLength(0); i++)
{
    for (int j = 0; j < metrix.GetLength(1); j++)
    {
        Console.Write($"{metrix[i, j]} ");
    }
    Console.WriteLine();
}


int[,] GreatMatrix(int strokcount, int stolbcount)
{
    int[,] metrix = new int[strokcount, stolbcount];

    Random rnd = new Random();
    for (int i = 0; i < metrix.GetLength(0); i++)
    {
        for (int j = 0; j < metrix.GetLength(1); j++)
        {
            metrix[i, j] = rnd.Next(1, 11);
        }

    }
    return metrix;
}
void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = GreatMatrix(5, 4);
ShowMatrix(matrix);

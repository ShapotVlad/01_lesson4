// задача2 создать и вывести  двумерный массив, а также вывести числа массива
//сумма цифр которых четна 
 

int[,] GreatMatrix(int strokcount, int stolbcount)
{
    int[,] matrix = new int[strokcount, stolbcount];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 1001);
        }

    }
    return matrix;
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

int[,] matrix = GreatMatrix(2, 3);
ShowMatrix(matrix);
foreach (int e in matrix)
{
    if (Isinterstig(e) == true)
    {
        Console.WriteLine(e);
    }
}

bool Isinterstig(int value)
{
    int sumDigit = GreatSumDigit(value);
    if (sumDigit % 2 == 0)
    {
        return true;
    }

    return false;

}

int GreatSumDigit(int value)
{
    int sum = 0;
    while (0 < value)
    {
        sum = sum + value % 10;
        value = value / 10;
    }
    return sum;
}


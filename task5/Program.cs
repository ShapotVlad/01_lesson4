// сообщить о наличии отрицательных элементов  в двумерном массиве

int[,] table = { {5, 12, 2},
                 {-9, 6, 4},
                 {7, -9, 5}};

for (int i = 0; i < table.GetLength(0); i++)
{
    for (int j = 0; j < table.GetLength(1); j++)
    {
        if (table[i, j] < 0)
        {
            Console.WriteLine($"есть отрицательное число в строке {i}");
            break;
        }
    }

}
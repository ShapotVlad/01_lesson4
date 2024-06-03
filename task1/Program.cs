//создание и вывод на консоль  двухмерного массива [3, 5];

int[,] metrix = new int[3, 4];           // создание случайного двумерного массива без исползования функции
Random rnd = new Random();
for (int i = 0; i < metrix.GetLength(0); i++)
{
    for (int j = 0; j < metrix.GetLength(1); j++)
    {
        metrix[i, j] = rnd.Next(1, 11);
    }

}

for (int i = 0; i < metrix.GetLength(0); i++)  //вывод на консоль  без исползования функции
{
    for (int j = 0; j < metrix.GetLength(1); j++)
    {
        Console.Write($"{metrix[i, j],2}  ");
    }
    Console.WriteLine();   //отделить строкой
}




Console.WriteLine();





int[,] GreatMatrix(int strokcount, int stolbcount) // создание случайного массива с исползованием функции
{
    int[,] metrix = new int[strokcount, stolbcount];

    Random rnd = new Random();
    for (int i = 0; i < metrix.GetLength(0); i++)
    {
        for (int j = 0; j < metrix.GetLength(1); j++)
        {
            metrix[i, j] = rnd.Next(1, 100);
        }

    }
    return metrix;
}
void ShowMatrix(int[,] matrix)                //вывод на консоль с исползованием функции
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine();
    }
}

int[,] matrix = GreatMatrix(4, 4);    //вызов функции создания массива
ShowMatrix(matrix);                   //вызов функции  вывода массива    










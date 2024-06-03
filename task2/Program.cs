// задача2 создать и вывести  двумерный массив, а также вывести числа массива
//сумма цифр которых четна 
 

int[,] GreatMatrix(int strokcount, int stolbcount) //создали функцию для создания двухмерного массива
{
    int[,] matrix = new int[strokcount, stolbcount];// определили таблицу

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

void ShowMatrix(int[,] matrix) // создали функцию для вывода таблицы
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

int[,] matrix = GreatMatrix(4, 4); //вызвали функцию создания массива
ShowMatrix(matrix);                 //вывали функцию вывода на консоль


foreach (int e in matrix)            // определяем интересные числа         
{
    if (Isinterstig(e) == true)
    {
        Console.WriteLine(e);//выводим на консоль интересные числа
    }
}

bool Isinterstig(int value) // создали функцию  для определения на четность суммы цифр чисел
{
    int sumDigit = GreatSumDigit(value);//вызываем  функцию суммы чисел
    if (sumDigit % 2 == 0)//определяем чётность суммы
    {
        return true;//если да, возвращаем число в  цикл форэч как интересное
    }

    return false;

}

int GreatSumDigit(int value) //создали функцию для подсчета суммы цифр
{
    int sum = 0; //создали счётчик суммы цифр
    while (0 < value)//считаем сумму цифр
    {
        sum = sum + value % 10;
        value = value / 10;
    }
    return sum;//возврат в счётчик суммы цифр
    }


﻿// сообщить о наличии отрицательных элементов  в двумерном массиве

int[,] table = { {5, 12, 2}, //вводим двумерный массив
                 {-9, 6, 4},
                 {7, -9, 5}};

for (int i = 0; i < table.GetLength(0); i++)// запускаем цикл прохождения массива по  строкам
{
    for (int j = 0; j < table.GetLength(1); j++)//запускаем цикл прохождения массива по столбцам
    {
        if (table[i, j] < 0)// если элемент массива отрицательный
        {
            Console.WriteLine($"есть отрицательное число в строке {i}");// выводим на консоль номер строки
            break;     // стоп программа
        }
    }

}
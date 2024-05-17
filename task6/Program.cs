// оператор управления continue

for (int i = 1; i <=  5; i++)
{
    Console.Write($"итерация {i}: ");

    if (i == 3)
    {
        Console.WriteLine("пропустить");
        continue;
    }
    Console.WriteLine("некоторая обработка");
}

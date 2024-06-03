// оператор управления continue

for (int i = 1; i <=  5; i++)//выводим  от 1 до 5
{
    Console.Write($"итерация {i}: ");

    if (i == 3)// пропустить 3 цикл
    {
        Console.WriteLine("пропустить");
        continue;
    }
    Console.WriteLine("некоторая обработка");
}

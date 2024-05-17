//выдать сообщение на экран
//если в массиве есть нечетное число

Console.WriteLine("start");

int[] numbers = { 4, 8, 12, 22, 16, 13, 18 };

foreach (int e in numbers)
{
    if( e % 2 == 1)
    {
        Console.WriteLine("есть число нечетное");
        break;
    }
}
Console.WriteLine("stop");

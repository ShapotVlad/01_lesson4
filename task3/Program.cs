// задача 3 ввести символы из клавиатуры и оставить только буквы


string GetLetter(string s) //задаем функцию для массива s
{
    string letter = ""; // задаем переменную для размещения  букв
    foreach (char e in s)
    {
        if (char.IsAsciiLetter(e) == true) //определяем является ли символ латинской буквой
        {
            letter = letter + e;
        }

    }
    return letter;
}
string str = Console.ReadLine(); // ввод символов 
string result = GetLetter(str);// запуск функции 
Console.WriteLine(result); // вывод  латинских букв
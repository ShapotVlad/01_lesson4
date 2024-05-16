// задача 3 ввести символы из клавиатуры и оставить только буквы


string GetLetter(string s)
{
    string letter = "";
    foreach (char e in s)
    {
        if (char.IsAsciiLetter(e) == true)
        {
            letter = letter + e;
        }

    }
    return letter;
}
string str = Console.ReadLine();
string result = GetLetter(str);
Console.WriteLine(result);
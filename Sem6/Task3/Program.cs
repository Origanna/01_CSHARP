// Считать строку с консоли, состоящую из латинских букв в нижнем регистре. Выяснить, сколько среди введённых букв гласных.
// Пример:
// “hello” => 2
// “world” => 1

int CountVowelsLetters(string str)
{
    string vowels = "eyuioa";
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        // for (int j = 0; j < vowels.Length; j++)
        // {
        // if (str[i] == vowels[j])
        if (vowels.Contains(str[i]))
        {
            count++;
        }
        // }
    }
    return count;
}

Console.WriteLine("Введите строку: ");
string str = Console.ReadLine();

Console.WriteLine($"В слове {CountVowelsLetters(str)} гласных");
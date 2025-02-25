// Задайте строку, состоящую из слов, разделённых пробелами. Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.
// Пример:
// "Hello my world" => "world my Hello"

string ReverseWords(string[] strNewSplit)
{
    string result = "";

    for (int i = strNewSplit.Length - 1; i >= 0; i--)
    {
        result += strNewSplit[i] + " ";
    }

    return result;
}

string strNew = "Hello my world";
string[] strNewSplit = strNew.Split(); // ["Hello", "my", "world"]
string result = ReverseWords(strNewSplit);
Console.WriteLine(result);
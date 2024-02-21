/*
Считать строку с консоли, содержащую латинские буквы.
Вывести на экран согласные буквы этой строки.
Указание
Использовать рекурсию. Не использовать цикл.
Пример
“hello” => h l l
“World” => W r l d
“Hello world!” => H l l w r l d

*/

bool IsLetter(char ch)
{
    // if (('a' <= ch && ch <= 'z') || ('A' <= ch && ch <= 'Z'))
    // {
    //     return true;
    // }
    // else
    // {
    //     return false;
    // }

    return (('a' <= ch && ch <= 'z') || ('A' <= ch && ch <= 'Z'));
}
bool isVowel (char ch)
{
    //string vowels = "aeoiuyAEOIUY";
    string vowels = "aeoiuy";
    vowels += vowels.ToUpper();
    for (int i = 0; i < vowels.Length; i++)
    {
        if (ch == vowels[i])
        {
            return true;
        }
    }
    return false;
}

void PrintConsonants(string word, int i = 0)
{
    if (i >= word.Length)
    {
        return;
    }

    //string vowels = "aeoiuy";
    // if (char.IsLetter(word[i]) && !vowels.Contains(word[i]))
    if (IsLetter(word[i]) && !isVowel(word[i]))
    {
        Console.Write(word[i] + " ");
    }
    PrintConsonants(word, i + 1);
}
PrintConsonants("Hello2AE5!");
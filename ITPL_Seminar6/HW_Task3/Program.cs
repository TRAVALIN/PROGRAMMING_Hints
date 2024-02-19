/*
Задача 3: Задайте произвольную строку. Выясните,
является ли она палиндромом.

“aBcD1ef!-” => Нет
“шалаш” => Да
“55655” => Да

*/



string str = "шалаш";
/* ДВА ВАРИАНТА РЕШЕНИЯ: */
// 1-й вариант:
bool e = false;
int count = 0;
for (int i = 0; i < str.Length / 2; i++)
{
    if (str[i] == str[str.Length - 1 - i])
    {
        e = true;
        if (e)
        {
            count++;
        }
    }
}
if (count == str.Length / 2)
{
    Console.WriteLine("Да это палиндром");
}
else
{
    Console.WriteLine("Нет это не палиндром");
}

// 2-й вариант
// РЕШЕНИЕ с использованием функций:
bool IsPalindrom(string str)
{
    bool a = false;
    bool b = false;
    int count = 0;
    for (int i = 0; i < str.Length / 2; i++)
    {
        if (str[i] == str[str.Length - 1 - i])
        {
            a = true;
            if (a)
            {
                count++;
            }
        }
    }
    if (count == str.Length / 2)
    {
        b = true;
    }
    return b;
}

void PrintIsPalindrom(bool b)
{
    if (b)
    {
        Console.WriteLine("Да это палиндром");
    }
    else
    {
        Console.WriteLine("Нет это не палиндром");
    }
}

bool isPalindrom = IsPalindrom(str);
PrintIsPalindrom(isPalindrom);


/* решение GeekBrains */


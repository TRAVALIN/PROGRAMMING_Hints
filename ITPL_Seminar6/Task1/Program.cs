/*
Задание 1. Совместная работа
Семинар 6. Массивы и строки
15 мин
Задайте массив символов (тип char []). Создайте строку из
символов этого массива.
Указание
Конструктор строки вида string(char []) не использовать.
char[] chars = new char[] { 'a', 'b', 'c', 'd'};
string str = new string(chars);

Пример
[‘a’, ‘b’, ‘c’, ‘d’] => “abcd”
*/

// char[] chars = new char[] { 'a', 'b', 'c', 'd'};
// string str = new string(chars);
// Console.Write(chars);
// Console.Write(str);

string ConvertToString(char[] chars)
{
    string str = ""; // можно задать через string.empty = слова препода, а как на практике непонятно
    for (int i = 0; i < chars.Length; i++)
    {
        str += chars[i];
    }
    return str;
}

char[] chars = { 'a', 'b', 'c', 'd', '#'};
string str = ConvertToString(chars);
Console.Write(str);
Console.Write("\n");
Console.Write(chars);
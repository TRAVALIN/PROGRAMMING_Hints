/*
Задача 1: Задайте двумерный массив символов
(тип char [,]). Создать строку из символов этого массива.

a b c => “abcdef”
d e f

*/


char[,] chars = new char[,]
{
    { 'a', 'b', 'c' },
    { 'd', 'e', 'f' }
};

string CreateString(char[,] chars)
{
    string str = "";
    for (int i = 0; i < chars.GetLength(0); i++)
    {
        for (int j = 0; j < chars.GetLength(1); j++)
        {
            str += chars[i, j];
        }
    }
    return str;
}

string str = CreateString(chars);
Console.Write(str);


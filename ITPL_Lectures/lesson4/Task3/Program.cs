/*
создание строк = массивов 

*/

string s1 = "Hello";

char[] ch = {'w', 'a', 'r'};
string s2 = new String(ch); //- можно создать в ручную через цикл с суммированием символов

Console.WriteLine(s1 + " " + s2);

string s3 = new String('a', 6); // символ и сколько раз повторяется
Console.WriteLine(s3);

/* некоторые методы строк:
Contains определяет содержится ли подстрока (символ) в строке
EndsWith определяет совпадает ли конец строки со подстрокой
применяется при поиске файлов по расширению
IndexO1 или IndexOI ??? Находит индекс первого вхождения символа
или подстроки в строке
Insert вставляет строку в подстроку
Replace замещает в строке символ или подстроку 
другим символом или подстрокой 
*/

/* ЗАМЕНИТЬ СИМВОЛЫ В СТРОКЕ НЕЛЬЗЯ 
ПРИВЕДЕННЫЕ МЕТОДЫ СОЗДАЮТ НОВЫЕ СТРОКИ */

string GetLettersFromString(string s)
{
    string letters = "";
    foreach (char e in s)
    {
        if (IsLetter(e) == true)
        {
            letters = letters + e;
        }
    }
    return letters;
}

bool IsLetter(char ch)
{
    if (('a' <= ch && ch <= 'z') || ('A' <= ch && ch <= 'Z'))
    {
        return true;
    }
    else
    {
        return false;
    }
}


string str = Console.ReadLine();
string result = GetLettersFromString(str);
Console.Write(result);


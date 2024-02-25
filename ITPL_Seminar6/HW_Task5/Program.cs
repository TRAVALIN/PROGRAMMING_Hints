
/*
Считать с консоли строку, состоящую из цифр и
латинских букв. Сформировать массив, состоящий
из цифр этой строки.
Пример
abc123def06g => [1, 2, 3, 0, 6]
Рекомендации
• Разделить логику алгоритма на функции
• Память под массив выделять необходимого
размера (не больше, чем количество элементов)
*/

int[] CreateArrayFromStringDigits(string digitsStr)
{
    int[] array = new int[digitsStr.Length];
    int digitsStr1 = int.Parse(digitsStr);
    for (int i = 0; i < digitsStr.Length; i++)
    {
        digitsStr1 = digitsStr1 % (int)Math.Pow(10, digitsStr.Length - i);

        array[i] = digitsStr1 / (int)Math.Pow(10, digitsStr.Length - i -1);
    }
    return array;
}

string GetDigetsFromString(string s)
{
    string digits = "";
    foreach (char e in s)
    {
        if (IsDigit(e) == true)
        {
            digits = digits + e;
        }
    }
    return digits;
}

bool IsDigit(char ch)
{
    if (('0' <= ch && ch <= '9'))
    {
        return true;
    }
    else
    {
        return false;
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write(array[i] + ", ");
        }
        else
        {
            Console.Write(array[i]);
        }
    }
}


string str = Console.ReadLine();
string digitsStr = GetDigetsFromString(str);
Console.WriteLine(digitsStr);
int[] array = CreateArrayFromStringDigits(digitsStr);
PrintArray(array);


//int result2 = int.Parse(digitsStr[0]);
//int result2 = int.Parse(result);
//Console.WriteLine(result2);


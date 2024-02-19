/*
Задание 3. Совместная работа
Семинар 6. Массивы и строки
20 мин
Считать строку с консоли, состоящую из латинских
букв в нижнем регистре. Выяснить, сколько среди
введённых букв гласных.
Пример
“hello” => 2
“world” => 1

*/

// bool IsVowel(char vow)
// {
//     // char[] vowels = {'a', 'e', 'i', 'o', 'u', 'y'};
//     string vowels = "aeiouy"; // здесь задаём массив символов char[] 
//     // с помощью строки, строка и является массивом символов
//     for (int i = 0; i < vowels.Length; i++)
//     {
//         if (vow == vowels[i])
//         {
//             return true;
//         }
//     }
//     return false;
// }

// int CountVowels(string str)
// {
//     int count_vowels = 0;
//     for (int i = 0; i < str.Length; i++)
//     {
//         if (IsVowel(str[i]))
//         {
//             count_vowels += 1;
//         }
//     }
//     return count_vowels;
// }


/* упрощаем
метод Contains заменяет нашу функцию IsVowel */
int CountVowels(string str)
{
    int count_vowels = 0;
    string vowels = "aeiouy";
    foreach (char item in str) // нужно испольовать char потому,
    // что принимается символ из строки,
    // но можно использовать var этот тип подстраивается под необходимый тип переменной
    {
        if (vowels.Contains(item)) // Contains = содержит /- получаем содержит элемент или нет
        {
            count_vowels += 1;
        }
    }
    return count_vowels;
}

string str = "heeello";
Console.WriteLine(CountVowels(str));

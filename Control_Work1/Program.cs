/*
Урок 1. Контрольная работа
Данная работа необходима для проверки ваших знаний и навыков
по итогу прохождения первого блока обучения на программе Разработчик.
Мы должны убедится, что базовое знакомство с IT прошло успешно.

Задача алгоритмически не самая сложная,
однако для полноценного выполнения проверочной работы необходимо:

1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма
(можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом
(не должно быть так, что всё залито одним коммитом,
как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

Задача: Написать программу, которая из имеющегося массива строк
формирует новый массив из строк, длина которых меньше,
либо равна 3 символам.

Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/


/* 1й ВАРИАНТ РЕШЕНИЯ: С СОЗДАНИЕМ ВТОРОГО МАССИВА СТРОК
и ПОСЛЕДУЮЩИМ ВЫВОДОМ ЕГО НА КОНСОЛЬ */
Console.WriteLine("1й ВАРИАНТ РЕШЕНИЯ:");
string[] stringsInput = { "Hello", "2", "world", ":-)" };
//string[] stringsInput = { "Rassia", "Denmark", "Kazan" };
int maxLengthStringsOutput = 3;

string[] CreateOutputArrayStrings(string[] strings)
{
    int sizeOutput = 0;
    for (int i = 0; i < strings.GetLength(0); i++)
    {
        if (strings[i].Length <= maxLengthStringsOutput)
        {
            sizeOutput++;
        }
    }
    string[] stringsOutput = new string[sizeOutput];
    int j = 0;
    for (int i = 0; i < strings.GetLength(0); i++)
    {
        if (strings[i].Length <= maxLengthStringsOutput)
        {
            stringsOutput[j] = strings[i];
            j++;
        }
    }
    return stringsOutput;
}

void PrintOutputArrayStrings(string[] strings)
{
    Console.Write("[");
    for (int i = 0; i < strings.GetLength(0); i++)
    {
        if (i < strings.GetLength(0) - 1)
        {
            Console.Write(strings[i] + ", ");
        }
        else
        {
            Console.Write(strings[i]);
        }
    }
    Console.Write("]");
}

string[] stringsOutput = CreateOutputArrayStrings(stringsInput);
PrintOutputArrayStrings(stringsOutput);

/* 2й ВАРИАНТ РЕШЕНИЯ: БЕЗ СОЗДАНИЯ ВТОРОГО МАССИВА.
ВЫВОД НА КОНСОЛЬ ТОЛЬКО НУЖНЫХ СТРОК ИЗ ЗАДАННОГО МАССИВА СТРОК */
Console.WriteLine();
Console.WriteLine("2й ВАРИАНТ РЕШЕНИЯ:");

string[] stringsInput2 = { "Hello", "2", "world", ":-)" };
//string[] stringsInput2 = { "Rassia", "Denmark", "Kazan" };
int maxLengthStringsOutput2 = 3;

Console.Write("[");
for (int i = 0; i < stringsInput2.GetLength(0); i++)
{
    if (stringsInput2[i].Length <= maxLengthStringsOutput2)
    {
        if (i < stringsInput2.GetLength(0) - 1)
        {
            Console.Write(stringsInput2[i] + ", ");
        }
        else
        {
            Console.Write(stringsInput2[i]);
        }
    }
}
Console.Write("]");

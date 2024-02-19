/*
Задание 2. Работа в сессионных залах
Семинар 6. Массивы и строки
На основе символов строки (тип string) сформировать массив
символов (тип char[]). Вывести массив на экран.
Указание
Метод строки ToCharArray() не использовать.
string str = "Hello";
char[] characters = str.ToCharArray();
Console.Write(characters);


Пример
“Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

*/

string str = "Hello";
//char[] characters = str.ToCharArray();
//Console.Write(characters);
Console.Write("\n");
Console.Write(123 + str);
Console.Write("\n");

Console.WriteLine("a" + "b");
Console.WriteLine('a' + 'b'); // здесь происходит сложение кодов из таблицы символов

/* заметки от преподавателя */
string input = "123, 54, 6546";
//var result = input.Split(); // разделяет строку на разные строки до пробела
var result = input.Split(", "); // разделяет строку убирая запятую и пробел
// в скобках указываем то, что нужно вырезать = убрать
foreach (var item in result)
{
    Console.WriteLine(item);
}

//var result2 = input.Split(", ").Select(item => int.Parse(item)).ToArray(); 
// Pars преобразование в число, ToArray в массив, 
// Select выбирает item и передаёт их в Parse на преобразование

var result2 = input.Split(", ").
            Select(item => int.Parse(item) * 10).ToArray();
for (int i = 0; i < result2.Length; i++)
{
    Console.Write(result2[i]*10); // вяводятся сразу числаю а не символы
    if (i < result2.Length - 1)
    {
        Console.Write(", ");
    }
}
Console.WriteLine();
// !!!! ВАЖНО ИСПОЛЬЗОВАТЬ var !!!!
// такой тип переменной подстраивается под получаемый в итоге тип выходных данных 

string input2 = "YddGGDF, NDDjjjo, UjbsaY";
var result3 = input2.Split(", ").
                    Select(item => item.ToLower()).
                    ToArray(); 
// приведение всех элементов к нижнему регистру
foreach (var item in result3)
{
    Console.WriteLine(item); // вяводятся сразу числаю а не символы
}

/* пример с result2 по выводу значений через запятую, 
без запятой после последнего элемента можно упростить */
Console.WriteLine(string.Join(", ", result2)); // здесь образуется строка и с помощью 
// функции Join (присоединить) выводятся значения через запятую
Console.WriteLine(string.Join(" : ", result3));
Console.WriteLine(string.Join(" :\n", result3));

// вместо Parse можно передавть и другие функции


/*
Задание 2. Работа в сессионных залах
Семинар 6. Массивы и строки
На основе символов строки (тип string) сформировать массив
символов (тип char[]). Вывести массив на экран.
Указание
Метод строки ToCharArray() не использовать.
string str = "Hello";
char[] characters = str.ToCharArray();
Console.Write(characters);


Пример
“Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]

*/

char[] ConvertToChars(string str2)
{
    int size = str.Length;
    char[] chars = new char[size];
    for (int i = 0; i < size; i++)
    {
        chars[i] = str[i];        
    }
    return chars;
}

string str2 = "Hello!";
char[] array = ConvertToChars(str2);
foreach (char item in array)
{
    Console.Write(item);
}
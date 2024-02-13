/*
Задание 3. Совместная работа
Семинар 4. Функции
20 мин
Заполните массив на N (вводится с консоли, не более 8)
случайных целых чисел от 0 до 9.
Сформируйте целое число, которое будет состоять из цифр из
массива. Старший разряд числа находится на 0-м индексе,
младший – на последнем.
Пример
[1 3 2 4 2 3] => 132423
[2 3 1] => 231
*/

int ConvertDigitsToNumber(int[] array)
{
    int number = 0;
    for (int i = 0; i < array.Length; i++)
    {
        number = number + array[i] * (int)Math.Pow(10, array.Length - 1 - i);
        // (int) преобразует double в int
        System.Console.WriteLine(array[i] * (int)Math.Pow(10, array.Length - 1 - i) + " " + number);
    }
    return number;
}


int[] CreateConsoleArray(int size) // числа от 1 до 9
{
    int N = size;
    int[] arr = new int[N];
    int i = 0;
    while (i < arr.Length)
    {
        Console.WriteLine("Введите целое число от 1 до 9:");
        string input = Console.ReadLine();
        int convert = Convert.ToInt32(input);
        if (convert >= 1 & convert < 10)
        {
            arr[i] = convert;
        }
        else
        {
            i--;
            Console.WriteLine("ЧИСЛО НЕ СООТВЕТСВУЕТ ДИАПАЗОНУ от 1 до 9 и не будет приниматься в расчёт!!!");
        }
        i++;
    }
    return arr;
}

void ShowPrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}


int[] array = CreateConsoleArray(8);

ShowPrintArray(array);

//int[] array = { 2, 3, 1 };
int num = ConvertDigitsToNumber(array);
System.Console.WriteLine(" ");
System.Console.Write(num);

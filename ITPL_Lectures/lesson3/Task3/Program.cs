﻿/* Массив является ссылочным типом данных.
Его имя это ячейка в памяти. Это его отличает
от значимых типов данных int и double,
что касается char, bool, string то тут ещё нужно разбараться.

Значения данных массива могут быть переданы в функцию
в качестве параметров, в отличие от значимых параметров.
*/

/* обнуляем чётные значения данных в массиве */

void ZeroEvenValue(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}
int[] array = { 2, 2, 3, 5, 6, 7, 8 };
ZeroEvenValue(array);
PrintArray(array);

/* переменные int, double, char можно передать по ссылке,
но делается это с помощью ключего слова ref (? на семинар)
*/
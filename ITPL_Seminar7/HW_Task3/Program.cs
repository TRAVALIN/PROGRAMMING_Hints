/*
Задача 3: Задайте произвольный массив. Выведете
его элементы, начиная с конца. Использовать
рекурсию, не использовать циклы.

[1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

*/

int[] array = { 1, 2, 5, 0, 10, 34 };
ReversOutputItemArray(array, array.Length - 1);
void ReversOutputItemArray(int[] array, int index)
{
    if (index + 1 == 0)
    {
        return;
    }
    Console.Write(array[index] + " ");
    ReversOutputItemArray(array, index - 1);
    return;
}

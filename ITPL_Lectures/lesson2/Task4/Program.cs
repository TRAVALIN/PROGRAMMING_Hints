/* Дано N гирь. Нужно определить вес
самой тяжёлой гири */

int[] arr = { 12, 55, 100, 3300, 3, 8 };
int i = 0;
int max = arr[0];

while (i < arr.Length)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    i = i + 1;
    //Console.Write(max);
}
Console.Write(max);
/*
PS G:\_TRAVALIN\PROGRAMMING_Hints\ITPL_Lectures\lesson2\Task4> dotnet run
121212121212121212121212121212 и т. д.
Постоянно выводится первый элемент массива. Потому что вывод максимального числа
находится в теле цикла While. Выключаем ошибучную строку и делаем вывод там,
где нужно = за пределами цикла. 
PS G:\_TRAVALIN\PROGRAMMING_Hints\ITPL_Lectures\lesson2\Task4> dotnet run
3300
*/

/* Цикл for
1. Перебор чисел массива, вывод их в консоль по порядку */

int[] arr2 = { 2, 6, 3, 0, 9 };
for (i = 0; i < arr2.Length; i = i + 1)
{
    Console.Write($"    {arr2[i]} ");
}

/*
2. Сумма чисел от 0 до n */

int n = 5;
int sum = 0;
for (i = 0; i <= n; i = i + 1)
{
    sum = sum + i;
}
Console.Write($"    {sum}");

/*
3. решение задачи с гирями */
max = arr[0]; /* ВАЖНО: Для j снова нужна
инициальзация переменной int потому,
что до этого её не было */
for (int j = 0; j < arr.Length; j++)
{
    if (arr[j] > max)
    max = arr[j];
}
Console.Write($"  {max} ");

/* Цикл foreach = только чтение массива без изменения переменных
1. Перебор чисел массива, вывод их в консоль по порядку */

int[] array = { 1, 2, 3, 4, 5, 6 };
foreach (int e in array)
{
    Console.Write($"    {e} ");
}

/* 
2. решение задачи с гирями */

max = arr[0]; /* ВАЖНО НЕТ int и с ним код не работает
видимо потому что с int задана max раньше */
foreach (int e in arr)
{
    if (e > max)
    max = e;
}
Console.Write($"  {max} ");

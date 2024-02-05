/*
Задайте массив. Напишите программу, которая определяет,
присутствует ли заданное число в массиве. Программа
должна выдать ответ: Да/Нет.
Примеры
[1 3 4 19 3], 8 => Нет
[-4 3 4 1], 3 => Да
*/


int[] arr = { 1, 3, 4, 19, 3 };
int a = 13;

/* первый способ */
bool inArr = false;
for (int i=0; i < arr.Length; i++)
{
    if (a == arr[i]) // ЕСЛИ ПЕРЕМЕННАЯ a соответствует числу в массиве с индексом i
    {
        inArr = true;
    }
}
if (inArr)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}


/* второй способ */
bool inArr2 = false;
foreach (int j in arr)
{
    if (a == j) // ЕСЛИ ПЕРЕМАННАЯ a соответсвует j-му числу в массиве
    {
        inArr2 = true;
    }
}
if (inArr2)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}

/* дополнительная информация о циклах */
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(i + ":" + arr[i]);
}

foreach (var item in arr) // foreach = for each = для каждого
{
    Console.WriteLine(item); 
}


/* Может показаться что bool переменная не нужна
в решениях выше и код можно упростить
как приведено ниже, но тогда вывод 
происходит после каждой проверки каждого элемента массива
 */

int[] arr3 = { 1, 3, 4, 19, 3 };
//int a = 13;

for (int i=0; i < arr3.Length; i++)
{
    if (a == arr3[i]) // ЕСЛИ ПЕРЕМЕННАЯ a соответствует числу в массиве с индексом i
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}

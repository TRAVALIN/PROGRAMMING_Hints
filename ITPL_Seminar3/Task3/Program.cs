/*
Найдите произведения пар чисел в одномерном массиве. Парой
считаем первый и последний элемент, второй и предпоследний и
т.д. Результат запишите в новый массив.
Пример
[1 3 2 4 2 3] => [3 6 8]
[2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)
*/

int[] arr = {2, 3, 1, 7, 5, 6, 3};
int[] result = new int [arr.Length / 2];
for (int i = 0, j = arr.Length - 1; i < arr.Length/2; i++, j--)
{
    result[i] = arr[i] * arr[j];
    Console.Write(result[i] + " ");
}

/* НУЖНО ДОРЕШАТЬ по элементу без пары */
int middleArr = 0;
int index_middleArr = 0;
if (arr.Length % 2 != 0)
{
    index_middleArr = arr.Length / 2;
    middleArr = arr[index_middleArr];
    Console.Write("Элемент " + middleArr + " не имеет пары" );
}
/* УРА! Дорешал! */
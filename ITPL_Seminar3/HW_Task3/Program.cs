/*
Задача 3: Задайте массив из вещественных чисел с
ненулевой дробной частью. Найдите разницу между
максимальным и минимальным элементов массива.
[2.2 0.4 9.11 7.2 78.98] => 78.58
*/

double[] arr = {2.2, 0.4, 9.11, 7.2, 78.98};
double min = arr[0];
double max = arr[0];
foreach (var item in arr)
{
    min = item < min ? item : min; // вместо if else = если да то item если нет то min
    max = item > max ? item : max; // вместо if else = если да то item если нет то min
}
//Console.WriteLine(min);
//Console.WriteLine(max);
Console.WriteLine(max - min);
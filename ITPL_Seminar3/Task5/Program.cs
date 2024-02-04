/*
Примеры использования команд 
для решения домашнего задания
*/

int[] arr = {19, 3, 8, 5};
int min = arr[0];
int max = arr[0];
foreach (var item in arr)
{
    min = item < min ? item : min; // вместо if else = если да то item если нет то min
    max = item > max ? item : max; // вместо if else = если да то item если нет то min
}
Console.WriteLine(min);
Console.WriteLine(max);
Console.WriteLine(max - min);
//int[] arr2 = {19, 3, 8, 5};
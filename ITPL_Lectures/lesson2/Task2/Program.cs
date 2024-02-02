/* вывод целых чисел от 1 до n */
int n = 10;
int[] arr = new int[n];
int i = 0;

while (i < n)
{
    arr[i] = i + 1;
    //Console.Write(arr[]);
    //Console.Write(' ');
    Console.Write($"{arr[i]} c ");
    i = i + 1;
}
/*
PS G:\_TRAVALIN\PROGRAMMING_Hints\ITPL_Lectures\lesson2\Task2> dotnet run
1 c 2 c 3 c 4 c 5 c 6 c 7 c 8 c 9 c 10 c 
*/

/* вывод целых чисел от 1 до n */
int n2 = 13;
int[] arr2 = new int[n2];
int j = 0;

/* while (j < arr.Length) /* можно n заменить свойством массива
Length (длина или размер массива) */
while (j < arr2.Length)
{
    arr2[j] = j + 1;
    //Console.Write(arr[j]);
    //Console.Write(' ');
    Console.Write($" {arr2[j]} ");
    j = j + 1;
}
/*
PPS G:\_TRAVALIN\PROGRAMMING_Hints\ITPL_Lectures\lesson2\Task2> dotnet run
1 c 2 c 3 c 4 c 5 c 6 c 7 c 8 c 9 c 10 c     1     2     3     4     5     6     7     8     9     10 
В КОНСОЛИ ВИДИМ ОШИБКУ ВМЕСТО 13 чисел 10.
ЭТО ПРОИЗОШЛО ПОТОМУ, ЧТО j < arr.Length а должно быть j < arr2.Length

ТЕПЕРЬ ВЕРНО:
PS G:\_TRAVALIN\PROGRAMMING_Hints\ITPL_Lectures\lesson2\Task2> dotnet run
1 c 2 c 3 c 4 c 5 c 6 c 7 c 8 c 9 c 10 c  1  2  3  4  5  6  7  8  9  10  11  12  13 
*/

/* Создать целочисленный массив из 10-ти чисел 
и вывести все чётные числа из массива */
// int[] arr3 = new int[10] { 7, 5, 12, 18, 16, 4, 88, 99, 3, 5 };
int[] arr3 = { 7, 5, 12, 18, 16, 4, 88, 99, 3, 5 };
int s = 0;

while (s < arr3.Length)
{
    if (arr3[s] % 2 == 0)
        Console.Write($"{arr3[s]} ");
    s = s + 1;
}

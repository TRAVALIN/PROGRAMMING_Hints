/*
Задайте массив из 10 элементов, заполненный числами из
промежутка [-10, 10]. Замените отрицательные элементы на
положительные, а положительные на отрицательные.
Пример
[1 -5 6]
=> [-1 5 -6]
*/

int[] arr = {1, -5, -6};
for (int i = 0; i < arr.Length; i++)
{
    //arr[i] = arr[i] * -1;
    arr[i] = -arr[i];
    Console.Write($"{arr[i]} ");
}

/* Первый пример не возможности применения
цикла foreach котрый не позволяет
изменять элементы массива
foreach (var item in arr)
{
    item = -item;
    Console.Write($"{item} ");
}
PS G:\_TRAVALIN\PROGRAMMING_Hints\ITPL_Seminar3\Task2> dotnet run
G:\_TRAVALIN\PROGRAMMING_Hints\ITPL_Seminar3\Task2\Program.cs(20,5): error CS1656:
Невозможно присвоить "item" значение, так как он является
 "переменная цикла foreach". 
[G:\_TRAVALIN\PROGRAMMING_Hints\ITPL_Seminar3\Task2\Task2.csproj]

*/
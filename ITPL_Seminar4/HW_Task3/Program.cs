/*
Задача 3: Напишите программу, которая перевернёт
одномерный массив (первый элемент станет
последним, второй – предпоследним и т.д.)
[1 3 5 6 7 8] => [8 7 6 5 3 1]
*/


int[] array = { 1, 3, 5, 6, 7, 8 };
ShowPrintArray(array);
int[] reversal_array = ReversalArray(array);
ShowPrintReversalArray(reversal_array);

void ShowPrintArray(int[] array)
{
    Console.Write("Заданный массив: [ ");
    foreach (var item in array)
    {
        Console.Write(item + " ");
    }
    Console.Write("]");
}

int[] ReversalArray(int[] array)
{
    int[] reversal_array = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        reversal_array[i] = array[array.Length - 1 - i];
    }
    return reversal_array;    
}


void ShowPrintReversalArray(int[] reversal_array)
{
    Console.WriteLine();
    Console.Write("Перевёрнутый массив: [ ");
    foreach (var item in reversal_array)
    {
        Console.Write(item + " ");
    }
    Console.Write("]");
}
/* РЕЗУЛЬТАТ РАБОТЫ ПРОГРАММЫ ИЗ КОНСОЛИ:

PS G:\_TRAVALIN\PROGRAMMING_Hints\ITPL_Seminar4\HW_Task3> dotnet run
Заданный массив: [ 1 3 5 6 7 8  ]
Перевёрнутый массив: [ 8 7 6 5 3 1  ]
*/

Console.Write("\nПеревернутый массив:"); // ИНТЕРЕСНЫЙ ХОД: \n перенос на следующую строку

// Заданный массив: [ 1 3 5 6 7 8 ]
// Перевёрнутый массив: [ 8 7 6 5 3 1 ]
// Перевернутый массив:
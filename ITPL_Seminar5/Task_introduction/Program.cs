int[,] matrix_0 = new int[4, 6];

Console.WriteLine("Создаём двумерный массив: int[,] matrix_0 = new int[4, 6];");
Console.WriteLine(matrix_0.Length + " - Количество элементов.");
Console.WriteLine(matrix_0.GetLength(0) + " - Количество строк.");
Console.WriteLine(matrix_0.GetLength(1) + " - Количество элементов в строке (столбец).");
Console.WriteLine();

/*
PS G:\_TRAVALIN\PROGRAMMING_Hints\ITPL_Seminar5\Task4> dotnet run
24 элемента
4 строки
6 столбцов = 6 элементов в строке
*/

Console.WriteLine(
    "Создаём двумерный массив.\n Количество строк и столбцов \n указываем в функции. Получаем:"
);

int[,] matrix1 = GetArray(3, 4);
PrintArray(matrix1);

int[,] matrix2 = GetArray2(2, 2);
PrintArray(matrix2);

FillArray(matrix1);
PrintArray(matrix1);

matrix1 = GetArray();
PrintArray(matrix1);

matrix1 = GetArray(cols:5);
PrintArray(matrix1);

matrix1 = GetArray(3); // заменяем в функции только первый параметр = переменную
PrintArray(matrix1);




int[,] GetArray(int rows = 10, int cols = 11) // здесь можно задавать переменные и без значений
// без = 10 и = 11 Далее когда объявляем функцию без аргументов применяются эти заданные значения
// а если при объявлении функции задать аргументы то параметры (переменные = 10 и = 11) перезапишутся
// можно и перезаписать каждый из параметров (смотри примеры объявления функций выше)
{
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i * 10 + j;
        }
    }
    return matrix;
}

int[,] GetArray2(int rows = 3, int cols = 2)
{
    int[,] matrix = new int[rows, cols];
    FillArray(matrix);
    return matrix;
}


void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j * 10;
        }
    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            //Console.Write($"{matrix[i, j]:f}")
            /* элемент массива (число) будет выводиться
            с двумя знаками после запятой (по умолчанию), можно добавлять
            кол-во знаков после запятой f1 f2 ... fn
            */
            //Console.Write(matrix[i, j] + "\t}") // \t знак табуляции после числа
            //Console.Write($"{matrix[i, j]:d2} "); // d2 для целых чисел 02 или d3 - 002 или d4 0003 ...
            /*
            00 01 02 03 04 05
            10 11 12 13 14 15
            20 21 22 23 24 25
            30 31 32 33 34 35
            */
            //Console.Write($"{matrix[i, j],3} "); // 3 - выделяется три места для числа, слева от числа
            /*
                0   1   2   3   4   5
                10  11  12  13  14  15
                20  21  22  23  24  25
                30  31  32  33  34  35
            */
            Console.Write($"{matrix[i, j], -3} "); // -3 - выделяется три места для числа, справа от числа
            /*
                0   1   2   3   4   5
                10  11  12  13  14  15
                20  21  22  23  24  25
                30  31  32  33  34  35
            */
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


/* При решении задач с функциями
вызов функций осуществляется в функции автотеста
вот пример вызова функци в решении задачи
ITPL_Seminar5 HW_Task3:

public static void PrintResult(int[,] numbers)
    {   
        int[] array = SumRows(number);
        int minIndex = MinIndex(array);
        PrintReault(minIndex);
    }

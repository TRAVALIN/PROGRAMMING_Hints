/*
Задайте двумерный массив. Найдите сумму элементов,
находящихся на главной диагонали (с индексами (0,0); (1;1) и
т.д.
Пример
2 3 4 3
4 3 4 1 => 2 + 3 + 5 = 10
2 9 5 4

*/

int[,] matrix =
{
    //{ 2, 3, 4, 3 },
    //{ 2, 3, 4, 3 },
    { 2, 3, 4, 3 },
    { 4, 3, 4, 1 },
    { 2, 9, 5, 4 }
};


// // Здесь проходим всю таблицу целиком, что 
// очень долго. Далее смотри как проходить 
// матрицу сразу по диагонали
// int ChangeMatrix(int[,] matrix)
// {
//     int sum = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                 sum += matrix[i, j];
//             }
//         }
//     }
//     return sum;
// }

int ChangeMatrix(int[,] matrix)
{
    int sum = 0;
    int matrixLength = Math.Min(matrix.GetLength(0), matrix.GetLength(1));
    //Console.Write(matrixLength + " ");
    for (int i = 0; i < matrixLength; i++)
    {
        sum += matrix[i, i];        
    }
    return sum;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 2} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintSum(int sum)
{
    Console.WriteLine("Сумма элементов на главной диагонали равна: " + sum);
}

PrintMatrix(matrix);
int sum = ChangeMatrix(matrix);
PrintSum(sum);

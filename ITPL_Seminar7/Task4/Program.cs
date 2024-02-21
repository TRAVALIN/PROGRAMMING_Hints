/* Введение про рекурсию в коде */

void TestFunction_1()
{
    Console.WriteLine("Fun 1 START");
    TestFunction_2();
    Console.WriteLine("Fun 1 END");
}

void TestFunction_2()
{
    Console.WriteLine("Fun 2 START");
    TestFunction_3();
    Console.WriteLine("Fun 2 END");
}

void TestFunction_3()
{
    Console.WriteLine("Fun 3 START");
    TestFunction_4();
    Console.WriteLine("Fun 3 END");
}

void TestFunction_4()
{
    Console.WriteLine("Fun 4 START");

    Console.WriteLine("Fun 4 END");
}
TestFunction_1();

Console.WriteLine();

// /* упрощаем запись */
// void TestFunction_n_in_1(int n)
// {
//     //Console.WriteLine($"Fun {n+1} Start");
//     TestFunction_n_in_1(n-1);
//     //Console.WriteLine($"Fun {n+1} Start");
// }
// TestFunction_n_in_1(1);

/*
В таком виде программа бесконечно вызывает себя
и переполняется память:
 Stack overflow.
Repeat 24105 times:
--------------------------------
   at Program.<<Main>$>g__TestFunction_n_in_1|0_4(Int32)
--------------------------------
   at Program.<Main>$(System.String[])
*/

/* упрощаем и уточняем чтобы не было бесконечного вычисления */
void TestFunction_n_in_1(int n)
{
    Console.WriteLine($"Fun {n} Start");

    if (n >= 4) // условие выхода из рекурсии
    {
        Console.WriteLine($"Fun {n + 1} End Whit if");
        return;
    }

    TestFunction_n_in_1(n + 1);

    Console.WriteLine($"Fun {n} End");
}
TestFunction_n_in_1(1);

Console.WriteLine();


int Fibb(int n) // получение числа Фиббоначи
{
    // Fibb(n) = Fibb(n -1) + Fibb(n-2)
    // 1, 1, 2, 3, 5, 8
    // 0, 1, 1, 2, 3, 5, 8
    if (n == 1 || n == 2)
    {
        return 1;
    }
    return Fibb(n -1) + Fibb(n-2);
}
Console.WriteLine(Fibb(6));

Console.WriteLine();

// for (int n = 1; n < 100; n++)
// {
//     Console.WriteLine($"Fibb{(n)} = {Fibb(n)}");

// }

// Этот варинант слишком меделенный
// потому что при рекурсии повторяется много 
// одних и тех же вычислений

// быстрый вариант подсчёта числа Фиббоначи:

int size = 100;
int[] fibbs = new int[size];

fibbs[0] = 1;
fibbs[1] = 1;

for (int i = 1; i < 100; i++)
{
    if (i >= 2)
    {
        fibbs[i] = fibbs[i-1] + fibbs[i-2];
    }
    Console.WriteLine($"Fibb{(i)} = {fibbs[i]}");
}

/* на 45-м ходу память переполнилась
и начали появляться из-за этого числа с минусом
и дальнейшие вычисления уже не верные
Fibb44 = 1134903170
Fibb45 = 1836311903
Fibb46 = -1323752223
Fibb47 = 512559680
*/
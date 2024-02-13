/*
Задача 1: Напишите программу, которая бесконечно
запрашивает целые числа с консоли. Программа
завершается при вводе символа ‘q’ или при вводе
числа, сумма цифр которого четная.
5 12 16 q [STOP]
3 45 342 15 [STOP]
*/

// Подсказки для выполнения задания:
// бесконечный цикл while (true)
// {
//    break; // остановка цикла
// }

int convertDigit = 0;
string input = "0";
while (true)
{
    Console.WriteLine("Введите число:");
    input = Console.ReadLine();
    
    if (input != "q")
    {
        convertDigit = Convert.ToInt32(input); // лучше пользоваться другим способом преобразования,
        // что значительно упрощает задачу см. HW_Task4
        //Console.WriteLine(convertDigit);
        
        // можно обойтись без следуюющего подсчёта количества цифр в числе
        int countDigit = 0;
        int x = convertDigit;
        while (x != 0) 
        {
            x /= 10;
            countDigit++;
        }
        // здесь заканчивается подсчёт цифр в числе.
        // Для следующего цикла считающего сумму числа
        // можно использовать другое условие в данном
        // случае (convertDigit > 0) это позволяет избавиться
        // и от других лишних переменных
        // решение см. HW_Task4
        
        int i = 0;
        int Digit = 0;
        int sum1 = 0;
        int x1 = convertDigit;
        while (i < countDigit)
        {
            Digit = x1 % 10;
            sum1 += Digit;
            x1 /= 10;
            i++;
        }
        if (sum1 % 2 == 0)
        {
            input = "q"; 
        }
        //Console.WriteLine(sum1);
    }
    
    if (input == "q")
    {
        break;
    }
}

/* Результат работы программы из консоли:
1. Сработка q:
PS G:\_TRAVALIN\PROGRAMMING_Hints\ITPL_Seminar4\HW_Task1> dotnet run
G:\_TRAVALIN\PROGRAMMING_Hints\ITPL_Seminar4\HW_Task1\Program.cs(21,13): 
warning CS8600: Преобразование литерала, допускающего значение NULL
или возможного значения NULL в тип, не допускающий значение NULL. 
G:\_TRAVALIN\PROGRAMMING_Hints\ITPL_Seminar4\HW_Task1\HW_Task1.csproj]
Введите число:
12
Введите число:
5
Введите число:
q
PS G:\_TRAVALIN\PROGRAMMING_Hints\ITPL_Seminar4\HW_Task1>

2. Сработка чётной суммы цифр числа:
PS G:\_TRAVALIN\PROGRAMMING_Hints\ITPL_Seminar4\HW_Task1> dotnet run
Введите число:
12
Введите число:
13
PS G:\_TRAVALIN\PROGRAMMING_Hints\ITPL_Seminar4\HW_Task1> 
*/

/* У меня получилось длинное решение из-за способа
определения чисел. И главное не знал как проверять
введено число или нет, поэтому в решении этого нет.
И про [STOP] совсем забыл.

ИТАК, вариант идеального решения от преподавателя
гораздо короче и полнее (с определением того, что 
введено с клавиатуры = число или нет):
смотри папку ITPL_Seminar4/HW_Task4
*/


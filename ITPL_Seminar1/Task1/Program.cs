﻿/* УСЛОВИЕ ЗАДАЧИ:
Напишите программу, которая на вход
принимает два целых числа и проверяет,
является ли первое число квадратом второго.
a = 25, b = 5 => да
a = 2, b = 10 => нет
a = 9, b = -3 => да
a = -3, b = 9 => нет */

// многострочный комментарий: в начале /* а в конце */

// РЕШЕНИЕ ЗАДАЧИ:
int a = 25; // Задаём первое целое число
int b = 5; // Задаём второе целое число
// int i = b * b; - отключенная строка ввиду того, что можно обойтись без задания этой переменной
// if (i == a) - отключенная строка потому, что отключена предыдущая строка
if (b * b == a) /* Задаём ветвление (не цикл!) с условием в скобках:
если равенство произведения (умножение второго целого числа на себя)
равно заданному первому числу, то выполняется следующее тело-действие: */
{
    Console.Write("ДА"); /* тело-действие отделяется с помощью фигурных скобок, 
    действие-операция: в консоли вывод на экран слова "ДА" (пишется слово "ДА"), 
    подтверждающего что первое число является квадратом второго */
}
else /* Если заданное выше ветвление (не цикл!) не выполняется
то выполняется следующее тело-действие: */
{
    Console.Write("НЕТ"); /* тело-действие отделяется с помощью фигурных скобок, 
    действие-операция: в консоли вывод на экран слова "НЕТ" (пишется слово "НЕТ"),
    подтверждающего что первое число не является квадратом второго */ 
}
/* точка с запятой ";" обозначает завершение выполнения отдельно взятой операции
внутри программы, поэтому ";" не ставится после условия цикла заданного в скобках. */
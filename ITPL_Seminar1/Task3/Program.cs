/* УСЛОВИЕ ЗАДАЧИ
Напишите программу, которая принимает на вход
трёхзначное целое число и на выходе показывает сумму
первой и последней цифры этого числа.
456 => 10
782 => 9
918 => 17
*/ 

// многострочный комментарий в начале /* а в конце */

// к командам и действиям без комментариев,
// комментарии даны в предыдущих заданиях

Console.WriteLine("     "+ "Дополнительная информация по решению задач с целыми числами:");
int number1 = 789;
int number2 = 10;

Console.WriteLine("1. Деление с выводом целого остатка от делимого:");
Console.WriteLine(number2 % 1); // результат 0 = остаток 10*1 = 10, 10-10 = 0
Console.WriteLine(number2 % 2); // результат 0 = остаток 5*2 = 10, 10-10 = 0
Console.WriteLine(number2 % 3); // результат 1 = остаток 3*3 = 9, 10-9 = 1
Console.WriteLine(number2 % 4); // результат 2 = остаток 4*2 = 8, 10-8 = 2
Console.WriteLine(number2 % 5); // результат 0 = остаток 2*5 = 10, 10-10 = 0
Console.WriteLine(number2 % 6); // результат 4 = остататок 1*6 = 6, 10-6 = 4
Console.WriteLine(number2 % 7); // результат 3 = остаток 1*7 = 7, 10-7 = 3
Console.WriteLine(number2 % 8); // результат 2 = остаток 8*1 = 8, 10-8 = 2
Console.WriteLine(number2 % 9); // результат 1 = остаток 7*1 = 7, 10-7 = 3
Console.WriteLine(number2 % 10); // результат 0 = остаток 10*1 = 10, 10-10 = 0
Console.WriteLine(" ");

Console.WriteLine("2. Деление целого числа на 10, 100, 1000 и т.д. и т.п.:");
Console.WriteLine(number1 / 10); // результат 78, число 9 после запятой выводится не будет
Console.WriteLine(number1 / 100); // результа 7, число 89 после запятой выводится не будет
Console.WriteLine(number1 / 1000); // результат 0, число 789 после запятой выводится не будет
Console.WriteLine(" ");

Console.WriteLine(number1 % 10); // результат 9, выводится результат после запятой 
Console.WriteLine(number1 % 100); // результат 89, выводится результат после запятой
Console.WriteLine(number1 % 1000); // результат 789, выводится результат после запятой
Console.WriteLine(" ");

// РЕШЕНИЕ ЗАДАЧИ:
Console.WriteLine("3. РЕШЕНИЕ ЗАДАЧИ:");
Console.WriteLine(" ");
Console.WriteLine("1-й Вариант решения задачи:");

int number = 456;
int FirstDigit = number / 100;
int lastDigit = number % 10;
int sum = FirstDigit + lastDigit;
Console.WriteLine("Первое число номера = "+ FirstDigit);
Console.WriteLine("Последнее число номера = "+ lastDigit);
Console.WriteLine("Сумма первого и последнего чисел = "+ sum);
/* В консоль выводится: 
3. 1-й Вариант РЕШЕНИЯ ЗАДАЧИ:
Первое число номера = 4
Последнее число номера = 6 */

Console.WriteLine(" ");
Console.WriteLine("2-й Вариант решения задачи:");
/*
int number1 = 456;
Console.WriteLine(number1 / 100 + number1 % 10);
/* В этом редакторе такое решение предложенное преподавателем не работает. Почему? Нужно разбираться. */ 

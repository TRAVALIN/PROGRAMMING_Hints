ЗДЕСЬ ПРИВЕДЕНЫ ЧАСТИ КОДОВ РЕШЕНИЯ ЗАДАЧ
В РАМКАХ ДОМАШНЕЙ = САМОСТОЯТЕЛЬНОЙ РАБОТЫ
НА ПЛАТФОРМЕ GeekBrains
ЭТИ КОДЫ НЕ ПОЛУЧИТСЯ ЗДЕСЬ ЗАПУСТИТЬ
В ТАКОМ ВИДЕ, НО В НИХ МОЖНО УВИДЕТЬ
ПОЛЕЗНЫЕ ПРИЁМЫ НЕ ПОПАДАВШИЕСЯ НА ГЛАЗА
ДО СИХ ПОР И ПРОСТО ОЗНАКОМИТСЯ С ЗАДАНИЯМИ 


1. /* РЕШЕНИЕ ТРАВАЛИН Большее из двух чисел, по следующему условию:
Внутри класса Answer напишите метод CompareNumbers, 
который на вход принимает два числа и выводит, 
какое число большее, а какое меньшее.

Пример использования:
На входе:
firstNumber: '5'
secondNumber: '6'
На выходе:
второе число больше

На входе:
firstNumber: '6'
secondNumber: '3'
На выходе:
первое число больше

На входе:
firstNumber: '3'
secondNumber: '3'
На выходе:
числа равны
*/

    static void CompareNumbers(int firstNumber, int secondNumber)
    {
         if (firstNumber < secondNumber)
         {
           Console.WriteLine("второе число больше");
         }
           else if (firstNumber > secondNumber)
         {
           Console.WriteLine("первое число больше");
         }
           else
         {
           Console.WriteLine("числа равны");
         }


2. /* РЕШЕНИЕ ТРАВАЛИН Максимальное из трех чисел, по следующему условию:
Внутри класса Answer напишите метод FindMax, 
который принимает на вход три числа и выдаёт максимальное из этих чисел. */

static int FindMax(int a, int b, int c)
    {
      int FindMax = a;
      if (b > FindMax)
      {
        FindMax = b;
      }
      if (c > FindMax)
      {
        FindMax = c;
      }
      return (FindMax); ВНИМАНИЕ!!! ВЫДАЁТ, А НЕ ВЫВОДИТ НА КОНСОЛЬ!!!!!

      /* по тому же условию решение в качестве примера: */
      static int FindMax(int a, int b, int c)
    {
      int max = a;
        if (max < b)
        {
            max = b;
        }
        if (max < c)
        {
            max = c;
        }
        return max; ВНИМАНИЕ!!! ВЫДАЁТ, А НЕ ВЫВОДИТ НА КОНСОЛЬ!!!!!

3. /* РЕШЕНИЕ ТРАВАЛИН Проверка на четность, по следующему условию:
Внутри класса Answer напишите метод CheckIfEven, 
который на вход принимает число number и выводит, 
является ли число чётным (делится ли оно на два без остатка).

Пример использования:
На входе:
number: '6'
На выходе:
четное

На входе:
number: '3'
На выходе:
нечетное
*/
static void PrintEvenNumbers(int number)
    
      int i = 0;
      while (i < number - 1)
      {
        i = i + 2;
        Console.Write(i+ " ");
      }
      
      /* по тому же условию решение в качестве примера: */
      for (int count = 2; count <= number; count += 2)
        {
            Console.Write($"{count} ");
        }

4. /* РЕШЕНИЕ ТРАВАЛИН Вывести четные числа, по следующему условию:
Внутри класса Answer напишите метод PrintEvenNumbers, 
которая на вход принимает число (number), 
а на выходе выводит все чётные числа от 1 до number (включительно), 
после каждого числа должен быть знак пробела.

Пример использования:
На входе:
number = 5 
На выходе:
2 4 

На входе:
number = 8 
На выходе:
2 4 6 8 
*/
static void PrintEvenNumbers(int number)
    
      int i = 0;
      while (i < number - 1)
      {
        i = i + 2; ВНИМАНИЕ ЭТУ ЗАПИСЬ МОЖНО ЗАМЕНИТЬ i += 2
        Console.Write(i+ " ");
      }
      /* по тому же условию решение в качестве примера: */
       for (int count = 2; count <= number; count += 2)
        {
            Console.Write($"{count} ");
        }

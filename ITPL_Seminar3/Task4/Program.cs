/*
Дано натуральное трёхзначное число. Создайте массив, состоящий из
цифр этого числа. Младший разряд числа должен располагаться на 0-
м (первом) индексе массива, старший – на последнем.
Пример
123456 => [6 5 4 3 2 1]
781 => [1 8 7]
15
*/

int a = 123456;
int x = a;
int countDigit = 0;
while (x != 0)
{
    x = x / 10;
    countDigit++;
}
int[] arr = new int[countDigit];
int i = 0;
int x1 = a;
while (i < countDigit)
{
    arr[i] = x1 % 10;
    Console.Write(arr[i] + " ");
    x1 = x1 / 10;
    //Console.WriteLine(x1);
    i = i + 1;
}

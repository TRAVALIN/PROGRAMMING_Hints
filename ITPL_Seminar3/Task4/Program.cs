/*
Задача 4*(не обязательно): Дано натуральное число
в диапазоне от 1 до 100 000. Создайте массив,
состоящий из цифр этого числа. Старший разряд
числа должен располагаться на 0-м индексе
массива, младший – на последнем. Размер массива
должен быть равен количеству цифр.
425 => [4 2 5]
8741 => [8 7 4 1]
4 => [4]

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
int[] arr2 = new int[countDigit];
int remained = a;

Console.Write("Обратный порядок: [ ");
for (int i = 0; i < arr.Length; i++) // foreach использовать нельзя, так  
// как происходит замена элементов массива имеющего первоначальные значения
// равные нулю 
{
    arr[i] = remained % 10;
    
    Console.Write(arr[i] + " ");
    remained = remained / 10;
}
Console.Write("]");
Console.WriteLine(" ");

Console.Write("Прямой порядок: [ ");
for (int i = 0; i < arr2.Length; i++)// foreach использовать нельзя, так  
// как происходит замена элементов массива имеющего первоначальные значения
// равные нулю 
{
    arr2[i] = arr[arr.Length - (i + 1)];
    Console.Write(arr2[i] + " ");
}
Console.Write("]");
/* Программа которая удаляет вторую цифру
трёхзначного числа 
а = 256 => 26
a = 891 => 81
*/

int a = 256;
int lastDigit = a % 10;
int FirstDigit = a / 100;
Console.Write(FirstDigit+ "" +lastDigit);
